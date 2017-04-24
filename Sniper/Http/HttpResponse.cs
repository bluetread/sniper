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
        public HttpResponse() : this(new WebHeaderCollection()) {}
      
        public HttpResponse(WebHeaderCollection responseHeaders)
        {
            ResponseHeaders = responseHeaders?.GetHeaders();
        }

        public HttpResponse(HttpStatusCode statusCode, WebHeaderCollection responseHeaders) : this(responseHeaders)
        {
            Ensure.ArgumentNotNull(nameof(statusCode), statusCode);
            StatusCode = statusCode;
        }

        public HttpResponse(HttpStatusCode statusCode, object body, WebHeaderCollection responseHeaders, string contentType)
        {
            Ensure.ArgumentNotNull(nameof(statusCode), statusCode);

            Body = body;
            ContentType = contentType;
            ResponseHeaders = responseHeaders?.GetHeaders();
            StatusCode = statusCode;
        }

        /// <summary>
        /// Optional additional information
        /// </summary>
        public Dictionary<Type, object> AdditionalInformation { get; set; } = new Dictionary<Type, object>();
        /// <summary>
        /// Raw response body. Typically a string, but when requesting images, it will be a byte array.
        /// </summary>
        public object Body { get; }
        /// <summary>
        /// The content type of the response.
        /// </summary>
        public string ContentType { get; }

        /// <summary>
        /// Quick way to identify that something went wrong.
        /// </summary>
        public bool IsError { get; set; } = true; // Default to True unless proven otherwise
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