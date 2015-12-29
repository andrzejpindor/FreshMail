using System;
using System.Linq;
using System.Net.Http;
using FreshMail.Configuration;
using FreshMail.Request;
using NUnit.Framework;

namespace FreshMail.Tests.Request
{
    public class HttpClientFactoryFixture
    {
        private const string BaseUri = "https://tempuri.org";
        private const string Sign = "KNOWN_SIGN";

        private readonly IFreshMailConfiguration _configuration;
        private readonly HttpClientFactory _factory;
        private HttpClient _client;

        public HttpClientFactoryFixture()
        {
            _configuration = new FreshMailConfiguration(new Uri(BaseUri), "APIKEY", "APISIGN");
            _factory = new HttpClientFactory(_configuration);
        }

        public HttpClient act()
        {
            _client = _factory.Create(Sign);
            return _client;
        }

        public void ApiKeyHeaderIsCorrect()
        {
            Assert.That(_client.DefaultRequestHeaders.GetValues("X-Rest-ApiKey").Single(), Is.EqualTo(_configuration.ApiKey));
        }

        public void ApiSignHeaderIsCorrect()
        {
            Assert.That(_client.DefaultRequestHeaders.GetValues("X-Rest-ApiSign").Single(), Is.EqualTo(Sign));
        }

        public void BaseUriIsCorrect()
        {
            Assert.That(_client.BaseAddress, Is.EqualTo(_configuration.BaseAddress));
        }
    }
    
}