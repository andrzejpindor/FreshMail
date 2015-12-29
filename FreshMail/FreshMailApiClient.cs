using FreshMail.Configuration;
using FreshMail.Converters;
using FreshMail.Request;
using FreshMail.Security;
using FreshMail.Wrappers;

namespace FreshMail
{
    public class FreshMailApiClient
    {
        public FreshMailApiClient(IFreshMailConfiguration configuration)
            : this(new RequestHandler(new HttpClientFactory(configuration),
                new SignProvider(configuration, new Sha1Provider()),
                new FreshmailJsonConverter()))
        {

        }

        protected FreshMailApiClient(RequestHandler requestHandler)
        {
            Ping = new PingWrapper(requestHandler);
            Sms = new SmsWrapper(requestHandler);
            CampaignsReports = new CampaignsReportsWrapper(requestHandler);
            SubscribersLists = new SubscribersListsWrapper(requestHandler);
            Subscribers = new SubscribersWrapper(requestHandler);
            Campaigns = new CampaignsWrapper(requestHandler);
        }

        public CampaignsWrapper Campaigns { get; set; }

        public PingWrapper Ping { get; }

        public TransactionMailWrapper TransactinoMail { get; set; }

        public SmsWrapper Sms { get; }

        public CampaignsReportsWrapper CampaignsReports { get; }

        public SubscribersListsWrapper SubscribersLists { get; }

        public SubscribersWrapper Subscribers { get; }
    }
}