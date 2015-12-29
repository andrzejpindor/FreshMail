using System.Net;

namespace FreshMail.Response
{
    public class EmptyApiResponse : IApiResponse
    {
        public HttpStatusCode HttpStatus { get; set; }
        public string Status { get; set; }
        public ErrorInfo[] Errors { get; set; }
    }
}