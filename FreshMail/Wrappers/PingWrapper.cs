using System.Threading.Tasks;
using FreshMail.Response;

namespace FreshMail.Wrappers
{
    public class PingWrapper : BaseWrapper
    {
        public PingWrapper(RequestHandler requestHandler) : base(requestHandler)
        {
        }

        public async Task<EmptyApiResponse> Run()
        {
            return await Handler.Execute<EmptyApiResponse>("ping");
        }
    }
}