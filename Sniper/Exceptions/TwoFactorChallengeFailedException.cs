using System;
using System.Diagnostics.CodeAnalysis;

namespace Sniper
{

    /// <summary>
    /// Represents a failed 2FA challenge from the API
    /// </summary>
    [Serializable]

    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors",
        Justification = "These exceptions are specific to the GitHub API and not general purpose exceptions")]
    public class TwoFactorChallengeFailedException : TwoFactorAuthorizationException
    {
#if false
        public override string Message => "The two-factor authentication code supplied is not correct";

        public string AuthorizationCode { get; }

        private static TwoFactorType ParseTwoFactorType(ApiException exception)
        {
            return exception == null ? TwoFactorType.None : Connection.ParseTwoFactorType(exception.HttpResponse);
        }

        [SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("AuthorizationCode", AuthorizationCode);
        }
#endif
    }
}
