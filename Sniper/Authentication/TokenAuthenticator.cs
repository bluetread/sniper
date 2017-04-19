using System;
using System.Globalization;
using Sniper.Authentication;
using Sniper.Http;
    
namespace Sniper
{
    internal class TokenAuthenticator : IAuthenticationHandler
    {
        private const string tokenFormat = "Token {0}";

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
            Ensure.ArgumentNotNull(HttpKeys.RequestParameters.Request, request);
            Ensure.ArgumentNotNull(AuthenticationKeys.Credentials, credentials);
            Ensure.ArgumentNotNull(AuthenticationKeys.CredentialsPassword, credentials.Password);

            var token = credentials.GetToken();
            if (credentials.Login != null)
            {
                throw new InvalidOperationException(AuthenticationKeys.Messages.TokenLoginFailed);
            }
            if (token != null)
            {
                request.Headers[AuthenticationKeys.Keys.Authorization] = string.Format(CultureInfo.InvariantCulture, tokenFormat, token);
            }
        }
    }
}
