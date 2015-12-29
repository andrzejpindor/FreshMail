using Newtonsoft.Json;

namespace FreshMail.Models.SubscribersLists.CustomFields
{
    public class CustomFieldItem
    {
        [JsonProperty(PropertyName = "id_hash")]
        public string Hash { get; set; }
        [JsonProperty(PropertyName = "field_name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "personalization_tag")]
        public string PersonalizationTag { get; set; }
        [JsonProperty(PropertyName = "field_type")]
        public CustomFieldType Type { get; set; }
    }
}