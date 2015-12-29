namespace FreshMail.Converters
{
    public interface IJsonConverter
    {
        string Serialize(object data);
        T Deserialize<T>(string data);
    }
}
