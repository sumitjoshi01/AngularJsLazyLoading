using System.Net;

namespace AngularJsRoutingPoc.Entities
{
    public class GenericResponse
    {
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
    }

    public class GenericResponse<T> : GenericResponse
    {
        public T Data { get; set; }
    }
}
