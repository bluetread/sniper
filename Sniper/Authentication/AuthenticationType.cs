using System;
using System.Diagnostics.CodeAnalysis;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    /// <summary>
    /// Authentication protocols supported by the TargetProcess API
    /// </summary>
    [SuppressMessage(Categories.Design, MessageAttributes.MarkEnumsWithFlags)]
    public enum AuthenticationType
    {
        /// <summary>
        /// Access Token
        /// </summary>
        AccessToken = 4,

        /// <summary>
        /// Anonymous Authentication (Not Allowed)
        /// </summary>
        Anonymous = 2,

        /// <summary>
        /// Cookie Authentication
        /// </summary>
        Cookie = 32,

        /// <summary>
        /// User name &amp; password
        /// </summary>
        Basic = 16,

        /// <summary>
        /// Service Token (Keyword is "token")
        /// </summary>
        ServiceToken = 8,

        /// <summary>
        /// Service Token
        /// </summary>
        Token = ServiceToken,

        /// <summary>
        /// Uknown/None/Default/Use config value
        /// </summary>
        Unknown = 0
    }

    public static class AuthenticationTypeExtensions
    {
        public static AuthenticationType AuthenticationTypeFromString(string type)
        {
            return Enum.TryParse(type, true, out AuthenticationType authenticationType) ? authenticationType : AuthenticationType.Cookie;
        }
    }
}