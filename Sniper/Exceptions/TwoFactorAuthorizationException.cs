using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;
using System.Security;
using Sniper.Http;

namespace Sniper
{

    /// <summary>
    /// Represents a failed 2FA challenge from the API
    /// </summary>
    [Serializable]

    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors",
        Justification = "These exceptions are specific to the GitHub API and not general purpose exceptions")]
    public abstract class TwoFactorAuthorizationException : AuthorizationException
    {
        protected TwoFactorAuthorizationException() { }

        /// <summary>
        /// Constructs an instance of TwoFactorRequiredException.
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="twoFactorType">Expected 2FA response type</param>
        protected TwoFactorAuthorizationException(IResponse response, TwoFactorType twoFactorType) : base(response)
        {
            Debug.Assert(response != null && response.StatusCode == HttpStatusCode.Unauthorized,
                "TwoFactorRequiredException status code should be 401");

            TwoFactorType = twoFactorType;
        }

        /// <summary>
        /// Constructs an instance of TwoFactorRequiredException.
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="twoFactorType">Expected 2FA response type</param>
        /// <param name="innerException">The inner exception</param>
        protected TwoFactorAuthorizationException(IResponse response, TwoFactorType twoFactorType, Exception innerException)
            : base(response, innerException)
        {
            Debug.Assert(response != null && response.StatusCode == HttpStatusCode.Unauthorized,
                "TwoFactorRequiredException status code should be 401");

            TwoFactorType = twoFactorType;
        }

        /// <summary>
        /// Expected 2FA response type
        /// </summary>
        public TwoFactorType TwoFactorType { get; }

        [SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("TwoFactorType", TwoFactorType);
        }
    }

    /// <summary>
    /// Methods for receiving 2FA authentication codes
    /// </summary>
    public enum TwoFactorType
    {
        /// <summary>
        /// No method configured
        /// </summary>
        None,
        /// <summary>
        /// Unknown method
        /// </summary>
        Unknown,
        /// <summary>
        /// Receive via SMS
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sms")]
        Sms,
        /// <summary>
        /// Receive via application
        /// </summary>
        AuthenticatorApp
    }
}
