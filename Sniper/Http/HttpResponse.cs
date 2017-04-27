using System;
using System.Collections.Generic;
using System.Net;

namespace Sniper.Http
{
    /// <summary>
    /// Represents a generic HTTP response
    /// </summary>
    internal class HttpResponse : IHttpResponse
    {
        public HttpResponse() : this(HttpStatusCode.InternalServerError) { }

        public HttpResponse(Exception exception = null) : this(HttpStatusCode.InternalServerError, exception) { }

        public HttpResponse(WebHeaderCollection responseHeaders)
        {
            ResponseHeaders = responseHeaders?.GetHeaders();
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

        public HttpResponse(HttpStatusCode statusCode, WebHeaderCollection responseHeaders) : this(responseHeaders)
        {
            Ensure.ArgumentNotNull(nameof(statusCode), statusCode);
            StatusCode = statusCode;
        }

        public HttpResponse(HttpStatusCode statusCode, object data, WebHeaderCollection responseHeaders)
        {
            Ensure.ArgumentNotNull(nameof(statusCode), statusCode);

            Data = data;
            ResponseHeaders = responseHeaders?.GetHeaders();
            StatusCode = statusCode;
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
        /// Information about the Response Headers.
        /// </summary>
        public IReadOnlyDictionary<string, string> ResponseHeaders { get; }

        /// <summary>
        /// The response status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; }
    }
}