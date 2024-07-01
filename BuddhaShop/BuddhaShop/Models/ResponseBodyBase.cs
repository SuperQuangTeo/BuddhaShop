using System.Net;

namespace BuddhaShop.Models
{
    public class ResponseBodyBase<T>
    {
        public HttpStatusCode statusCode { get; set; }
        public T? data { get; set; }
        public string? message { get; set; }
    }
}
