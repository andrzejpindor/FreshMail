using System;
using System.Net;
using System.Net.Http;
using FreshMail.Configuration;

namespace FreshMail.Request
{
    public class HttpClientFactory
    {
        private readonly IFreshMailConfiguration _configuration;

        public HttpClientFactory(IFreshMailConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            _configuration = configuration;
        }

        public HttpClient Create(string sign)
        {
            HttpClient client =
                new HttpClient(new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                })
                {
                    BaseAddress = _configuration.BaseAddress,
                    Timeout = _configuration.Timeout
                };

            client.DefaultRequestHeaders.Add("X-Rest-ApiKey", _configuration.ApiKey);
            client.DefaultRequestHeaders.Add("X-Rest-ApiSign", sign);
            return client;
        }
    }
}