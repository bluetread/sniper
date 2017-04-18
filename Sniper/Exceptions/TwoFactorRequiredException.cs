using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Sniper.Http;

namespace Sniper
{
    /// <summary>
    /// 
    /// </summary>

    [Serializable]

    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors",
        Justification = "These exceptions are specific to the GitHub API and not general purpose exceptions")]
    public class TwoFactorRequiredException : TwoFactorAuthorizationException
    {
     

        /// <summary>
        /// Constructs an instance of TwoFactorRequiredException.
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="twoFactorType">Expected 2FA response type</param>
        public TwoFactorRequiredException(IResponse response, TwoFactorType twoFactorType)
            : base(response, twoFactorType)
        {
            Debug.Assert(response != null && response.StatusCode == HttpStatusCode.Unauthorized,
                "TwoFactorRequiredException status code should be 401");
        }

        //public override string Message => ApiErrorMessageSafe ?? "Two-factor authentication code is required";

    }
}
