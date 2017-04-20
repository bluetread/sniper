#if false
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class OAuthToken
    {
        public OAuthToken() { }

        public OAuthToken(string tokenType, string accessToken, IReadOnlyList<string> scope)
        {
            TokenType = tokenType;
            AccessToken = accessToken;
            Scope = scope;
        }

        /// <summary>
        /// The type of OAuth token
        /// </summary>
        public string TokenType { get; protected set; }

        /// <summary>
        /// The secret OAuth access token. Use this to authenticate Sniper's client.
        /// </summary>
        public string AccessToken { get; protected set; }

        /// <summary>
        /// The list of scopes the token includes.
        /// </summary>
        public IReadOnlyList<string> Scope { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "TokenType: {0}, AccessToken: {1}, Scopes: {2}",
            TokenType,
            AccessToken,
            Scope);
    }
}
#endif