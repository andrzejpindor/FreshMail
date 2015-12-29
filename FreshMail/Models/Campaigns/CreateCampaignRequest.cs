using Newtonsoft.Json;

namespace FreshMail.Models.Campaigns
{
    public class CreateCampaignRequest
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "html")]
        public string Html { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
        [JsonProperty(PropertyName = "from_address")]
        public string From { get; set; }
        [JsonProperty(PropertyName = "from_name")]
        public string FromName { get; set; }
        [JsonProperty(PropertyName = "reply_to")]
        public string ReplyTo { get; set; }
        [JsonProperty(PropertyName = "list")]
        public string ListHash { get; set; }
        [JsonProperty(PropertyName = "resignlink")]
        public string ResignLink { get; set; }
    }
}