using System;
using Newtonsoft.Json;

namespace FreshMail.Models.Reports
{
    public class CampaignTimeItem
    {
        public int Opened { get; set; }
        public int Clicked { get; set; }
        [JsonProperty(PropertyName = "unique_opened")]
        public int UniqueOpened { get; set; }
        [JsonProperty(PropertyName = "unique_clicked")]
        public int UniqueClicked { get; set; }
        public DateTime Time { get; set; }
    }
}
