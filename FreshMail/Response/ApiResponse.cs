using System.Net;

namespace FreshMail.Response
{
    public class ApiResponse<T> : IApiResponse
    {
        public HttpStatusCode HttpStatus { get; set; }
        public string Status { get; set; }
        public ErrorInfo[] Errors { get; set; }
        public virtual T Data { get; set; }
    }
}