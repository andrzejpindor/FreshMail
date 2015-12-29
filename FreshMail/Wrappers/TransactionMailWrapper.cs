using System.Threading.Tasks;
using FreshMail.Models.TransactionMail;
using FreshMail.Response;

namespace FreshMail.Wrappers
{
public class TransactionMailWrapper : BaseWrapper
    {
        public TransactionMailWrapper(RequestHandler requestHandler) : base(requestHandler)
        {

        }

        public async Task<EmptyApiResponse> Send(TransactionMailData data)
        {
            return await Handler.Execute<EmptyApiResponse>("mail", data);
        }
    }
}