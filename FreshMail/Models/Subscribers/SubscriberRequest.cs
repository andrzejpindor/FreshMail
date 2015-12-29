using System.Collections.Generic;
using Newtonsoft.Json;

namespace FreshMail.Models.Subscribers
{
    public class SubscriberRequest
    {
        public SubscriberRequest(string listHash, string email, SubscriberStatus status)
        {
            Fields = new Dictionary<string, string>();
            ListHash = listHash;
            Email = email;
            Status = status;
        }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "list")]
        public string ListHash { get; set; }

        [JsonProperty(PropertyName = "state")]
        public SubscriberStatus Status { get; set; }

        [JsonProperty(PropertyName = "custom_fields")]
        public Dictionary<string, string> Fields { get; }

        public void AddCustomField(string personalizationTag, string value)
        {
            Fields.Add(personalizationTag, value);
        }
    }
}