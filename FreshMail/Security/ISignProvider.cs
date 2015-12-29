namespace FreshMail.Security
{
    public interface ISignProvider
    {
        string Provide(string action, string data);
    }
}