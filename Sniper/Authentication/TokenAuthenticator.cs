using System;
using System.Globalization;
using Sniper.Http;
using static Sniper.Constants;
    
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
        ///See the <a href="http://developer.github.com/v3/#oauth2-token-sent-in-a-header">OAuth2 Token (sent in a header) documentation</a> for more information.
        ///</remarks>
        public void Authenticate(IRequest request, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(Authentication.Request, request);
            Ensure.ArgumentNotNull(Authentication.Credentials, credentials);
            Ensure.ArgumentNotNull(Authentication.CredentialsPassword, credentials.Password);

            var token = credentials.GetToken();
            if (credentials.Login != null)
            {
                throw new InvalidOperationException(Authentication.Messages.TokenLoginFailed);
            }
            if (token != null)
            {
                request.Headers[Authentication.Keys.Authorization] = string.Format(CultureInfo.InvariantCulture, "Token {0}", token);
            }
        }
    }
}
