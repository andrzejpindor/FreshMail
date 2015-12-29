using Newtonsoft.Json;

namespace FreshMail.Models.Subscribers
{
    public class CustomFieldData
    {
        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}