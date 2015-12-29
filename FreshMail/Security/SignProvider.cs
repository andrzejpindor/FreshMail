using System;
using FreshMail.Configuration;

namespace FreshMail.Security
{
    public class SignProvider : ISignProvider
    {
        private readonly IFreshMailConfiguration _configuration;
        private readonly Sha1Provider _sha1Provider;

        public SignProvider(IFreshMailConfiguration configuration, Sha1Provider sha1Provider)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            if (sha1Provider == null)
            {
                throw new ArgumentNullException(nameof(sha1Provider));
            }

            _configuration = configuration;
            _sha1Provider = sha1Provider;
        }

        public string Provide(string action, string data)
        {
            return
                _sha1Provider.ProvideHash(string.Format("{0}{1}{2}{3}", _configuration.ApiKey,
                    new Uri(_configuration.BaseAddress, action).PathAndQuery,
                    data, _configuration.ApiSecret));
        }
    }
}
