using System;
using System.Threading.Tasks;
using FreshMail.Models.Campaigns;
using FreshMail.Response;

namespace FreshMail.Wrappers
{
    public class CampaignsWrapper : BaseWrapper
    {
        public CampaignsWrapper(RequestHandler requestHandler) : base(requestHandler)
        {
        }

        public async Task<ApiResponse<CreateCampaignResponse>> Add(CreateCampaignRequest request)
        {
            return await Handler.Execute<ApiResponse<CreateCampaignResponse>>("campaigns/create", request);
        }

        public async Task<EmptyApiResponse> SendTest(string campaignHash, params string[] testEmails)
        {
            return await Handler.Execute<EmptyApiResponse>("campaigns/sendTest", new { hash = campaignHash, emails = testEmails });
        }

        public async Task<EmptyApiResponse> Send(string campaignHash, DateTime? sendDate = null)
        {
            return await Handler.Execute<EmptyApiResponse>("campaigns/send", new { hash = campaignHash, time = sendDate.HasValue ? sendDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : null });
        }

        public async Task<EmptyApiResponse> Delete(string campaignHash)
        {
            return await Handler.Execute<EmptyApiResponse>("campaigns/delete", new {hash = campaignHash});
        }
    }
}