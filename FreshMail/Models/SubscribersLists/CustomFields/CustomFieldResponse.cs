using FreshMail.Response;
using Newtonsoft.Json;

namespace FreshMail.Models.SubscribersLists.CustomFields
{
    public class CustomFieldResponse : EmptyApiResponse
    {
        [JsonProperty(PropertyName = "field")]
        public CustomFieldItem Field { get; set; }
    }
}