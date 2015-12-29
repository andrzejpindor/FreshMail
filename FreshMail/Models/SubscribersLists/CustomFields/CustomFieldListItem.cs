using Newtonsoft.Json;

namespace FreshMail.Models.SubscribersLists.CustomFields
{
    public class CustomFieldListItem
    {
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
}