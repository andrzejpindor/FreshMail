using System.Net.Http;
using System.Text;

namespace FreshMail.Request
{
    public class FreshmailContent : StringContent
    {
        public FreshmailContent(string content) : base(content, Encoding.UTF8, "application/json")
        {
            //this must be cleared, otherwise there is sign error - in my opinion this is a bug on freshmail servers
            Headers.ContentType.CharSet = null;
        }
    }
}