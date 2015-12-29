using Newtonsoft.Json;

namespace FreshMail.Models.SubscribersLists.CustomFields
{
    public class CustomField
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
        [JsonProperty(PropertyName = "type")]
        public CustomFieldType Type { get; set; }

    }
}