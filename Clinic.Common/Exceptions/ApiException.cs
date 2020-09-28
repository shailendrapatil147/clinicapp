using System;
using System.Net;

namespace Clinic.Common.Exceptions
{
    public class ApiException: Exception
    {
        public ApiException(HttpStatusCode statusCode, string message): base(message)
        {
            StatusCode = statusCode;
            DisplayMessage = message;
        }
        public ApiException(HttpStatusCode statusCode, string message, Exception innerException) : base(message, innerException)
        {
            StatusCode = statusCode;
            DisplayMessage = message;
        }

        public string DisplayMessage { get; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
