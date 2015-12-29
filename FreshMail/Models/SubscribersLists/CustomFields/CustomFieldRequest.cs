using Newtonsoft.Json;

namespace FreshMail.Models.SubscribersLists.CustomFields
{
    public class CustomFieldRequest : CustomField
    {
        public CustomFieldRequest(string listHash, string name)
        {
            ListHash = listHash;
            Name = name;
        }

        [JsonProperty(PropertyName = "hash")]
        public string ListHash { get; set; }
    }
}