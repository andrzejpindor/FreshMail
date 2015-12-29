using System.Threading.Tasks;
using FreshMail.Models.Subscribers;
using FreshMail.Response;

namespace FreshMail.Wrappers
{
    public class SubscribersWrapper : BaseWrapper
    {
        public SubscribersWrapper(RequestHandler requestHandler) : base(requestHandler)
        {

        }

        public async Task<EmptyApiResponse> Add(AddSubscriberRequest request)
        {
            return await Handler.Execute<EmptyApiResponse>("subscriber/add", request);
        }

        public async Task<EmptyApiResponse> Edit(SubscriberRequest request)
        {
            return await Handler.Execute<EmptyApiResponse>("subscriber/edit", request);
        }

        public async Task<ApiResponse<SubscriberData>> Get(string listHash, string email)
        {
            return await Handler.Execute<ApiResponse<SubscriberData>>(string.Format("subscriber/get/{0}/{1}", listHash, email));
        }

        public async Task<EmptyApiResponse> Delete(string listHash, string email)
        {
            return await Handler.Execute<EmptyApiResponse>("subscriber/delete", new {list = listHash, email = email});
        }
    }
}