using Newtonsoft.Json;

namespace FreshMail.Models.Reports
{
    public class CampaignReport
    {
        public int Subscribers { get; set; }
        public int Delivered { get; set; }
        [JsonProperty(PropertyName = "hard_bounce")]
        public int HardBounce { get; set; }
        [JsonProperty(PropertyName = "soft_bounce")]
        public int SoftBounce { get; set; }
        public int Opened { get; set; }
        public int Clicked { get; set; }
        [JsonProperty(PropertyName = "unique_opened")]
        public int UniqueOpened { get; set; }
        [JsonProperty(PropertyName = "unique_clicked")]
        public int UniqueClicked { get; set; }
        public int Resigned { get; set; }
    }
}