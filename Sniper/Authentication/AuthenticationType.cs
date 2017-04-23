using System;

namespace Sniper
{
    /// <summary>
    /// Authentication protocols supported by the TargetProcess API
    /// </summary>
    public enum AuthenticationType
    {
        /// <summary>
        /// Access Token
        /// </summary>
        AccessToken,
        /// <summary>
        /// Anonymous Authentication (Not Allowed)
        /// </summary>
        Anonymous,
        /// <summary>
        /// Cookie Authentication
        /// </summary>
        Cookie,
        /// <summary>
        /// User name &amp; password
        /// </summary>
        Basic,
        /// <summary>
        /// Service Token (Keyword is "token")
        /// </summary>
        ServiceToken,
        /// <summary>
        /// Service Token
        /// </summary>
        Token = ServiceToken
    }

    public static class AuthenticationTypeExtensions
    {
        public static AuthenticationType AuthenticationTypeFromString(string type)
        {
            return Enum.TryParse(type, true, out AuthenticationType authenticationType) ? authenticationType : AuthenticationType.Cookie;
        }
    }
}
