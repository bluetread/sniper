using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Sniper.Http;

namespace Sniper
{
    /// <summary>
    /// Represents a HTTP 422 - Unprocessable Entity response returned from the API.
    /// </summary>

    [Serializable]

    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors",
        Justification = "These exceptions are specific to the GitHub API and not general purpose exceptions")]
    public class ApiValidationException : ApiException
    {

        public ApiValidationException() {}

#if false
        /// <summary>
        /// Constructs an instance of ApiValidationException
        /// </summary>
        public ApiValidationException() : base((HttpStatusCode)422, null)
        {
        }
#endif
        /// <summary>
        /// Constructs an instance of ApiValidationException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        public ApiValidationException(IResponse response) : this(response, null) {}

        /// <summary>
        /// Constructs an instance of ApiValidationException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="innerException">The inner exception</param>
        public ApiValidationException(IResponse response, Exception innerException)
            : base(response, innerException)
        {
            Debug.Assert(response != null && response.StatusCode == (HttpStatusCode)422,
                "ApiValidationException created with wrong status code");
        }
#if false
        /// <summary>
        /// Constructs an instance of ApiValidationException
        /// </summary>
        /// <param name="innerException">The inner exception</param>
        protected ApiValidationException(ApiException innerException) : base(innerException)
        {
        }
#endif
        //public override string Message => ApiErrorMessageSafe ?? "Validation Failed";


    }
}
