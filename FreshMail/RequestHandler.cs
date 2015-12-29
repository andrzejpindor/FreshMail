using System.Net.Http;
using System.Threading.Tasks;
using FreshMail.Converters;
using FreshMail.Request;
using FreshMail.Response;
using FreshMail.Security;

namespace FreshMail
{
    public class RequestHandler
    {
        private readonly HttpClientFactory _clientFactory;
        private readonly SignProvider _signProvider;
        private readonly IJsonConverter _jsonConverter;

        public RequestHandler(HttpClientFactory clientFactory, SignProvider signProvider, IJsonConverter jsonConverter)
        {
            _clientFactory = clientFactory;
            _signProvider = signProvider;
            _jsonConverter = jsonConverter;
        }

        public async Task<TResponse> Execute<TResponse>(string action, object data = null)
            where TResponse : IApiResponse
        {
            TResponse result;

            string serializedData = _jsonConverter.Serialize(data);
            string sign = _signProvider.Provide(action, serializedData);

            using (HttpClient client = _clientFactory.Create(sign))
            {
                HttpResponseMessage response;

                if (data != null)
                {
                    response = await client.PostAsync(action,
                        new FreshmailContent(serializedData));
                }
                else
                {
                    response = await client.GetAsync(action);
                }

                result = _jsonConverter.Deserialize<TResponse>(response.Content.ReadAsStringAsync().Result);
                result.HttpStatus = response.StatusCode;
            }

            return result;
        }
    }
}