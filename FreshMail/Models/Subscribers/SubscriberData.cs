using Newtonsoft.Json;

namespace FreshMail.Models.Subscribers
{
    public class SubscriberData
    {
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "state")]
        public SubscriberStatus Status { get; set; }

        [JsonProperty(PropertyName = "custom_fields")]
        public CustomFieldData[] Fields { get; set; }
    }
}