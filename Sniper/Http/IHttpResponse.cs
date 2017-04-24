using System;
using System.Collections.Generic;
using System.Net;

namespace Sniper.Http
{
    /// <summary>
    /// Represents a generic HTTP response
    /// </summary>
    public interface IHttpResponse
    {
        /// <summary>
        /// Raw response body. Typically a string, but when requesting images, it will be a byte array.
        /// </summary>
        object Body { get; }

        /// <summary>
        /// The content type of the response.
        /// </summary>
        string ContentType { get; }

        /// <summary>
        /// Quick way to identify that something went wrong.
        /// </summary>
        bool IsError { get; }

        /// <summary>
        /// Information about the Response
        /// </summary>
        IReadOnlyDictionary<string, string> ResponseHeaders { get; }

        /// <summary>
        /// The response status code.
        /// </summary>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Optional additional information
        /// </summary>
        Dictionary<Type, object> AdditionalInformation { get; }
    }
}
