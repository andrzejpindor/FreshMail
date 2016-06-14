using Newtonsoft.Json;

namespace FreshMail.Models.Sms
{
    public class SmsRequest
    {
        [JsonProperty(PropertyName = "gsm")]
        public string Msisdn { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }
        [JsonProperty(PropertyName = "single")]
        public SingleSettings Single { get; set; }
        public SmsRequest(string msisdn, string message, string proName = null,
            SingleSettings singleSettings = SingleSettings.Off)
        {
            Msisdn = msisdn;
            Message = message;
            From = proName;
            Single = singleSettings;
        }
    }
}