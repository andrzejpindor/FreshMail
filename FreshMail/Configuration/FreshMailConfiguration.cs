using System;

namespace FreshMail.Configuration
{
    public class FreshMailConfiguration : IFreshMailConfiguration
    {
        public FreshMailConfiguration(Uri baseAddress, string apiKey, string apiSecret):
            this(baseAddress, apiKey, apiSecret, TimeSpan.FromSeconds(30))
        {

        }

        public FreshMailConfiguration(Uri baseAddress, string apiKey, string apiSecret, TimeSpan timeout)
        {
            if (baseAddress == null)
            {
                throw new ArgumentException(nameof(baseAddress));
            }

            if (IsSsl(baseAddress) == false)
            {
                throw  new ArgumentException("Base address uri scheme must be https");
            }

            if (apiKey == null)
            {
                throw new ArgumentException(nameof(baseAddress));
            }

            if (apiSecret == null)
            {
                throw new ArgumentException(nameof(apiSecret));
            }

            BaseAddress = baseAddress;
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            Timeout = timeout;
        }

        public Uri BaseAddress { get; }
        public string ApiKey { get; }
        public string ApiSecret { get; }
        public TimeSpan Timeout { get; }

        private static bool IsSsl(Uri baseAddress)
        {
            return string.Compare(baseAddress.Scheme.ToUpperInvariant(), "HTTPS", StringComparison.InvariantCulture) == 0;
        }
    }
}