using Sniper.Http;
using System;
using System.Globalization;
using static Sniper.Authentication.AuthenticationKeys;

namespace Sniper
{
    internal class TokenAuthenticator : IAuthenticationHandler
    {

        ///<summary>
        ///Authenticate a request using the OAuth2 Token (sent in a header) authentication scheme
        ///</summary>
        ///<param name="request">The request to authenticate</param>
        ///<param name="credentials">The credentials to attach to the request</param>
        ///<remarks>
        ///See the <a href="http://developer.github.com/v3/#oauth2-token-sent-in-a-header">OAuth2 Token (sent in a header) documentation</a> for more information. //TODO: Replace with TargetProcess
        ///</remarks>
        public void Authenticate(IRequest request, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(nameof(request), request);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);
            Ensure.ArgumentNotNull(nameof(credentials.Password), credentials.Password);

            var token = credentials.GetToken();
            if (credentials.Login != null)
            {
                throw new InvalidOperationException(Messages.TokenLoginFailed);
            }
            if (token != null)
            {
                request.Headers[Keys.Authorization] = string.Format(CultureInfo.InvariantCulture, Messages.TokenAuthorizationMessageFormat, token);
            }
        }
    }
}
