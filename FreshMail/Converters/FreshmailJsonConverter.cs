using Newtonsoft.Json;

namespace FreshMail.Converters
{
    public class FreshmailJsonConverter : IJsonConverter
    {
        private static readonly JsonSerializerSettings Settings;

        static FreshmailJsonConverter()
        {
            Settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            Settings.Converters.Add(new BoolConverter());
        }

        public string Serialize(object data)
        {
            return data == null
                ? null
                : JsonConvert.SerializeObject(data, Formatting.None, Settings);
        }

        public T Deserialize<T>(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(data, Settings);
        }
    }
}