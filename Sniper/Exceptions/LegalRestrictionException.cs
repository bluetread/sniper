using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Sniper.Http;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    /// <summary>
    /// Represents a HTTP 451 - Unavailable For Legal Reasons response returned from the API.  //TODO: Replace with TargetProcess if this is usable
    /// This will returned if GitHub has been asked to takedown the requested resource due to
    /// a DMCA takedown.
    /// </summary>

    [Serializable]

    [SuppressMessage(Categories.Design, MessageAttributes.ImplementStandardExceptionConstructors, Justification = Justifications.SpecificToTargetProcess)]
    public class LegalRestrictionException : ApiException
    {
        //public override string Message => ApiErrorMessageSafe ?? "Resource taken down due to a DMCA notice.";

        /// <summary>
        /// Constructs an instance of LegalRestrictionException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        public LegalRestrictionException(IResponse response) : this(response, null)
        {
        }

      

        /// <summary>
        /// Constructs an instance of LegalRestrictionException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="innerException">The inner exception</param>
        public LegalRestrictionException(IResponse response, Exception innerException)
            : base(response, innerException)
        {
            Debug.Assert(response != null && response.StatusCode == (HttpStatusCode)451,
                "LegalRestrictionException created with wrong status code");
        }


    }
}
