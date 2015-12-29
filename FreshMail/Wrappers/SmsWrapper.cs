using System.Threading.Tasks;
using FreshMail.Models.Sms;
using FreshMail.Response;

namespace FreshMail.Wrappers
{
    public class SmsWrapper : BaseWrapper
    {
        public SmsWrapper(RequestHandler requestHandler) : base(requestHandler)
        {
        }

        public async Task<EmptyApiResponse> Send(SmsRequest smsRequest)
        {
            return await Handler.Execute<EmptyApiResponse>("sms", smsRequest);
        }
    }
}