using Newtonsoft.Json;

namespace FreshMail.Models.Subscribers
{
    public class AddSubscriberRequest : SubscriberRequest
    {
        public AddSubscriberRequest(string listHash, string email, SubscriberStatus status)
            : base(listHash, email, status)
        {

        }

        [JsonProperty(PropertyName = "confirm")]
        public bool Confirm { get; set; }
    }
}