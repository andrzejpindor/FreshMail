using System;
using Newtonsoft.Json;

namespace FreshMail.Models.SubscribersLists
{
    public class SubscriberList
    {
        [JsonProperty(PropertyName = "subscriberListHash")]
        public string Hash { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonProperty(PropertyName = "creation_date")]
        public DateTime CreationDate { get; set; }
        [JsonProperty(PropertyName = "subscribers_number")]
        public int Subscribers { get; set; }
    }
}