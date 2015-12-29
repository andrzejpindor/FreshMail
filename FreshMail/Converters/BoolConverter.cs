using System;
using Newtonsoft.Json;

namespace FreshMail.Converters
{
    public class BoolConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue((bool)value ? 1 : 0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string value = reader.Value.ToString();
            if (IsFalse(value))
            {
                return false;
            }

            if (IsTrue(value))
            {
                return true;
            }

            throw new ArgumentOutOfRangeException(nameof(reader.Value), string.Format("Value is {0} but expected 0 or 1", value));
        }

        private bool IsTrue(string value)
        {
            return Compare(value, "1");
        }

        private static bool IsFalse(string value)
        {
            return Compare(value, "0");
        }

        private static bool Compare(string value, string expected)
        {
            return string.Compare(value, expected, StringComparison.InvariantCultureIgnoreCase) == 0;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof (bool);
        }
    }
}
