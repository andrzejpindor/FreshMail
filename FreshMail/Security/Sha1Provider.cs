using System;
using System.Security.Cryptography;
using System.Text;

namespace FreshMail.Security
{
    public class Sha1Provider
    {
        public string ProvideHash(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            StringBuilder builder = new StringBuilder();

            using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(data));

                foreach (byte t in hash)
                {
                    builder.Append(t.ToString("X2"));
                }
            }

            return builder.ToString().ToLower();
        }
    }
}
