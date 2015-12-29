namespace FreshMail.Wrappers
{
    public class BaseWrapper
    {
        protected RequestHandler Handler { get; }

        public BaseWrapper(RequestHandler requestHandler)
        {
            Handler = requestHandler;
        }
    }
}