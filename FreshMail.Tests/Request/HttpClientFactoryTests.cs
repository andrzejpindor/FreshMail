using NUnit.Framework;

namespace FreshMail.Tests.Request
{
    [TestFixture]
    public class HttpClientFactoryTests
    {
        private HttpClientFactoryFixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _fixture = new HttpClientFactoryFixture();
        }

        [Test]
        public void ApiKey_IsSet()
        {
            _fixture.act();

            _fixture.ApiKeyHeaderIsCorrect();
        }

        [Test]
        public void ApiSign_IsSet()
        {
            _fixture.act();

            _fixture.ApiSignHeaderIsCorrect();
        }

        [Test]
        public void BaseAddress_IsSet()
        {
            _fixture.act();

            _fixture.BaseUriIsCorrect();
        }
    }
}