using System.Threading.Tasks;
using FreshMail.Models.Reports;
using FreshMail.Response;

namespace FreshMail.Wrappers
{
    public class CampaignsReportsWrapper : BaseWrapper
    {
        public CampaignsReportsWrapper(RequestHandler requestHandler) : base(requestHandler)
        {

        }

        public async Task<ApiResponse<CampaignInfo[]>> List(int page = 1)
        {
            return await Handler.Execute<ApiResponse<CampaignInfo[]>>(string.Format("reports/campaignsList/{0}", page));
        }

        public async Task<ApiResponse<CampaignReport>> GeneralReport(string hash)
        {
            return await Handler.Execute<ApiResponse<CampaignReport>>(string.Format("reports/campaign/{0}", hash));
        }
        public async Task<ApiResponse<CampaignTimeItem[]>> CampaignTimeDetails(string hash)
        {
            return await Handler.Execute<ApiResponse<CampaignTimeItem[]>>(string.Format("reports/campaignTimeDetails/{0}", hash));
        }
    }
}