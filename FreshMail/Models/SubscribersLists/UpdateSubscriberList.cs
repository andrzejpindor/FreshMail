using Newtonsoft.Json;

namespace FreshMail.Models.SubscribersLists
{
    public class UpdateSubscriberList : SubscriberListRequest
    {
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }
    }
}