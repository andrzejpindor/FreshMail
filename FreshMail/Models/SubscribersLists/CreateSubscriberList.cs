using System.Collections.Generic;
using FreshMail.Models.SubscribersLists.CustomFields;
using Newtonsoft.Json;

namespace FreshMail.Models.SubscribersLists
{
    public class CreateSubscriberList : SubscriberListRequest
    {
        public CreateSubscriberList()
        {
            CustomFields = new List<CustomField>();
        }
        
        [JsonProperty(PropertyName = "custom_fields")]
        public List<CustomField> CustomFields { get; set; } 
    }
}