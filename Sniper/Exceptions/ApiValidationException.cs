using System;
using System.Diagnostics;
using System.Net;
using Sniper.Http;
using static Sniper.WarningsErrors.MessageSuppression;
using System.Diagnostics.CodeAnalysis;

namespace Sniper
{
    /// <summary>
    /// Represents a HTTP 422 - Unprocessable Entity response returned from the API.
    /// </summary>

    [Serializable]

    [SuppressMessage(Categories.Design, MessageAttributes.ImplementStandardExceptionConstructors, Justification = Justifications.SpecificToTargetProcess)]
    public class ApiValidationException : ApiException
    {
        private const string apiValidationException = "ApiValidationException created with wrong status code";

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
            Debug.Assert(response != null && response.StatusCode == (HttpStatusCode)422, apiValidationException);
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
