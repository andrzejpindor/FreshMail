using Newtonsoft.Json;

namespace FreshMail.Models.SubscribersLists
{
    public class SubscriberListRequest
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
