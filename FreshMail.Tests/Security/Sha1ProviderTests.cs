using System;
using NUnit.Framework;

namespace FreshMail.Tests.Security
{
    [TestFixture]
    public class Sha1ProviderTests
    {
        private Sha1ProviderFixture _fixture;
        [SetUp]
        public void SetUp()
        {
            _fixture = new Sha1ProviderFixture();
        }

        [Test]
        public void Null_Input_Throws_ArgumentNull()
        {
            _fixture.SetNullInput();

            Assert.Throws<ArgumentNullException>(() => _fixture.act());
        }
        
        [TestCase("1234567890", "01b307acba4f54f55aafc33bb06bbbf6ca803e9a")]
        [TestCase("abcdef", "1f8ac10f23c5b5bc1167bda84b833e5c057a77d2")]
        [TestCase("0123456789abcdefghijklmnopqrstuwvxyz(){}:<>?;',./!@#$%^&*()-=_+", "f19aabbc25c76c128d0e1b8af38af4560e7a4e37")]
        public void SimpleInput_HashIsGenerated(string input, string hash)
        {
            _fixture.SetInput(input);

            string result = _fixture.act();

            Assert.AreEqual(hash, result);
        }

        [TestCase("ąęółńćźżĘÓŹŻŃŁŚ", "5c706708ec1dc1b177b21fc05d590a74ffe54002")]
        [TestCase("áéíóúüñÁÉÍÓÚÜÑ", "f3f5c729289214e55222a660a396c442bef0e5d5")]
        public void InputWithDiacritics_HashIsGenerated(string input, string hash)
        {
            _fixture.SetInput(input);

            string result = _fixture.act();

            Assert.AreEqual(hash, result);
        }

        [Test]
        public void Empty_Input_Throws_ArgumentNull()
        {
            _fixture.SetNullInput();

            Assert.Throws<ArgumentNullException>(() => _fixture.act());
        }
    }
}
