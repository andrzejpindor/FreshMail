using System;
using FreshMail.Security;

namespace FreshMail.Tests.Security
{
    internal class Sha1ProviderFixture
    {
        private readonly Sha1Provider _provider = new Sha1Provider();

        private string _input;

        public void SetNullInput()
        {
            SetInput(null);
        }

        public void SetEmptyInput()
        {
            SetInput(String.Empty);
        }

        public void SetInput(string input)
        {
            _input = input;
        }
        public string act()
        {
            return _provider.ProvideHash(_input);
        }
    }
}