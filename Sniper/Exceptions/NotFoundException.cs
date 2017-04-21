using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Sniper.Http;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    /// <summary>
    /// Represents a HTTP 404 - Not Found response returned from the API.
    /// </summary>

    [Serializable]

    [SuppressMessage(Categories.Design, MessageAttributes.ImplementStandardExceptionConstructors, Justification = Justifications.SpecificToTargetProcess)]
    public class NotFoundException : ApiException
    {
        /// <summary>
        /// Constructs an instance of NotFoundException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        public NotFoundException(IResponse response) : this(response, null) {}

#if false
        /// <summary>
        /// Constructs an instance of NotFoundException
        /// </summary>
        /// <param name="message">The exception message</param>
        /// <param name="statusCode">The http status code returned by the response</param>
        public NotFoundException(string message, HttpStatusCode statusCode) : base(message, statusCode)
        {
        }
#endif
        /// <summary>
        /// Constructs an instance of NotFoundException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="innerException">The inner exception</param>
        public NotFoundException(IResponse response, Exception innerException) : base(response, innerException)
        {
            Debug.Assert(response != null && response.StatusCode == HttpStatusCode.NotFound,
                "NotFoundException created with wrong status code"); //TODO:const
        }
    }
}
