using System;
using System.Net;
using System.Net.Http.Headers;

namespace Sniper.Http
{
    /// <summary>
    /// Represents a generic HTTP response
    /// </summary>
    public interface IHttpResponse
    {
        /// <summary>
        /// Raw response data. Typically a string, but when requesting images, it will be a byte array.
        /// </summary>
        object Data { get; }

        /// <summary>
        /// Quick way to identify that something went wrong.
        /// </summary>
        bool IsError { get; }

        /// <summary>
        /// Information about the Response
        /// </summary>
        HttpResponseHeaders ResponseHeaders { get; }

        /// <summary>
        /// The response status code.
        /// </summary>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Optional exception information
        /// </summary>
        Exception Exception { get; }

        /// <summary>
        /// The content type of the response.
        /// </summary>
        string ContentType { get; }
    }
}