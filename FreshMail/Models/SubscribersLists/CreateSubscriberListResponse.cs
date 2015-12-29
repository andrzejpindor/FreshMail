using FreshMail.Response;

namespace FreshMail.Models.SubscribersLists
{
    public class CreateSubscriberListResponse : EmptyApiResponse
    {
        public string Hash { get; set; }
    }
}