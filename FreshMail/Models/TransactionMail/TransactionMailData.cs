using Newtonsoft.Json;

namespace FreshMail.Models.TransactionMail
{
    public class TransactionMailData
    {
        public TransactionMailData(string to, string subject)
        {
            To = to;
            Subject = subject;
        }

        [JsonProperty(PropertyName = "subscriber")]
        public string To { get; set; }
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
        [JsonProperty(PropertyName = "html")]
        public string Html { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }
        [JsonProperty(PropertyName = "from_name")]
        public string FromName { get; set; }
        [JsonProperty(PropertyName = "reply_to")]
        public string ReplyTo { get; set; }
        [JsonProperty(PropertyName = "encoding")]
        public string Encoding { get; set; }
        [JsonProperty(PropertyName = "attachments")]
        public string Attachments { get; set; }
        [JsonProperty(PropertyName = "tracking")]
        public string Tracking { get; set; }
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
}
