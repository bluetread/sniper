using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;

namespace Sniper.Http
{
    /// <summary>
    /// Represents a generic HTTP response
    /// </summary>
    internal class HttpResponse : IHttpResponse
    {
        private HttpStatusCode _statusCode;
        private readonly ICollection<HttpStatusCode> _successCodeList = new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
            HttpStatusCode.Accepted,
            HttpStatusCode.Created,
            HttpStatusCode.NonAuthoritativeInformation,
            HttpStatusCode.NoContent,
            HttpStatusCode.ResetContent,
            HttpStatusCode.PartialContent
        };

        public HttpResponse() : this(HttpStatusCode.InternalServerError) { }

        public HttpResponse(Exception exception = null) : this(HttpStatusCode.InternalServerError, exception) { }

        public HttpResponse(HttpResponseHeaders responseHeaders)
        {
            ResponseHeaders = responseHeaders;//?.GetHeaders();
        }

        public HttpResponse(object obj) : this(HttpStatusCode.OK)
        {
            Data = obj;
        }

        public HttpResponse(HttpStatusCode statusCode, Exception exception = null)
        {
            Ensure.ArgumentNotNull(nameof(statusCode), statusCode);
            StatusCode = statusCode;
            Exception = exception;
        }

        public HttpResponse(HttpStatusCode statusCode, HttpResponseHeaders responseHeaders) : this(responseHeaders)
        {
            Ensure.ArgumentNotNull(nameof(statusCode), statusCode);
            StatusCode = statusCode;
        }

        public HttpResponse(HttpStatusCode statusCode, object data) : this(statusCode)
        {
            Ensure.ArgumentNotNull(nameof(data), data);
            Data = data;
        }

        public HttpResponse(HttpStatusCode statusCode, object data, HttpResponseHeaders responseHeaders) : this(statusCode, data)
        {
            Ensure.ArgumentNotNull(nameof(statusCode), statusCode);

            Data = data;
            ResponseHeaders = responseHeaders;//?.GetHeaders();
            StatusCode = statusCode;
        }

        public HttpResponse(HttpStatusCode statusCode, object data, HttpResponseHeaders responseHeaders, string contentType)
            : this(statusCode, data, responseHeaders)
        {
            ContentType = contentType;
        }


        /// <summary>
        /// Optional additional information
        /// </summary>
        public Dictionary<Type, object> AdditionalInformation { get; set; } = new Dictionary<Type, object>();

        /// <summary>
        /// Raw response data. Typically a string, but when requesting images, it will be a byte array.
        /// </summary>
        public object Data { get; }

        /// <summary>
        /// Quick way to identify that something went wrong.
        /// </summary>
        public bool IsError { get; set; } = true; // Default to True unless proven otherwise

        /// <summary>
        /// Optional Exception info if an error occurred
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// The content type of the response.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Information about the Response Headers.
        /// </summary>
        public HttpResponseHeaders ResponseHeaders { get; }

        /// <summary>
        /// The response status code.
        /// </summary>
        public HttpStatusCode StatusCode
        {
            get => _statusCode;
            private set
            {
                IsError = true;
                if (_successCodeList.Contains(value))
                {
                    IsError = false;
                }
                _statusCode = value;
            }
        }
    }
}