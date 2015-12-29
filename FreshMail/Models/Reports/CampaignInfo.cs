using System;
using Newtonsoft.Json;

namespace FreshMail.Models.Reports
{
    public class CampaignInfo
    {
        public string Name { get; set; }
        public string Topic { get; set; }
        public int Subscribers { get; set; }
        [JsonProperty(PropertyName = "id_hash")]
        public string Hash { get; set; }
        public DateTime Sent { get; set; }
    }
}
