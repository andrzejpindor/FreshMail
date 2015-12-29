using System.Net;

namespace FreshMail.Response
{
    public interface IApiResponse
    {
        HttpStatusCode HttpStatus { get; set; }
        string Status { get; set; }
        ErrorInfo[] Errors { get; set; }
    }
}