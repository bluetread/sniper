#if false
using System;
using System.Diagnostics;
using System.Globalization;
using Sniper.Authentication;

namespace Sniper.Request
{
    /// <summary>
    /// Used to create an Oauth login request.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class OAuthTokenRequest : RequestParameters  //TODO: Replace with TargetProcess if this is usable
    {
        /// <summary>
        /// Creates an instance of the OAuth login request with the required parameter.
        /// </summary>
        /// <param name="clientId">The client Id you received from GitHub when you registered the application.</param>
        /// <param name="clientSecret">The client secret you received from GitHub when you registered.</param>
        /// <param name="code">The code you received as a response to making the OAuth login request</param>
        public OAuthTokenRequest(string clientId, string clientSecret, string code)
        {
            Ensure.ArgumentNotNullOrEmptyString(AuthenticationKeys.ClientId, clientId);
            Ensure.ArgumentNotNullOrEmptyString(AuthenticationKeys.ClientSecret, clientSecret);
            Ensure.ArgumentNotNullOrEmptyString(AuthenticationKeys.Code, code);

            ClientId = clientId;
            ClientSecret = clientSecret;
            Code = code;
        }

        /// <summary>
        /// The client Id you received from GitHub when you registered the application.  //TODO: Replace with TargetProcess if this is usable
        /// </summary>
        [Parameter(Key = "client_id")]
        public string ClientId { get; }

        /// <summary>
        /// The client secret you received from GitHub when you registered.
        /// </summary>
        [Parameter(Key = "client_secret")]
        public string ClientSecret { get; }

        /// <summary>
        /// The code you received as a response to making the <see cref="IOAuthClient.CreateAccessToken">OAuth login  //TODO: Replace with TargetProcess if this is usable
        /// request</see>.
        /// </summary>
        [Parameter(Key = "code")]
        public string Code { get; }

        /// <summary>
        /// The URL in your app where users will be sent after authorization.
        /// </summary>
        /// <remarks>
        /// See the documentation about <see href="https://developer.github.com/v3/oauth/#redirect-urls">redirect urls  //TODO: Replace with TargetProcess if this is usable
        /// </see> for more information.
        /// </remarks>
        [Parameter(Key = "redirect_uri")]
        public Uri RedirectUri { get; set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "ClientId: {0}, ClientSecret: {1}, Code: {2}, RedirectUri: {3}",
            ClientId,
            ClientSecret,
            Code,
            RedirectUri);
    }
}
#endif