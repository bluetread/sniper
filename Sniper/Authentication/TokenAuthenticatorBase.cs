using System.Globalization;
using Sniper.Http;
using static Sniper.Authentication.AuthenticationKeys;

namespace Sniper
{
    internal abstract class TokenAuthenticatorBase : IAuthenticationHandler
    {

        ///<summary>
        ///Authenticate a request using the Token (AccessToken or ServiceToken) authentication scheme
        ///</summary>
        ///<param name="request">The request to authenticate</param>
        ///<param name="credentials">The credentials to attach to the request</param>
        ///<remarks>
        ///See the <a href="https://dev.targetprocess.com/docs/authentication#section-token-authentication">Token (sent in a header) documentation</a> for more information. 
        ///</remarks>
        public virtual void Authenticate(IRequest request, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(nameof(request), request);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);
            Ensure.ArgumentNotNull(nameof(credentials.Password), credentials.Password);

            var token = credentials.GetToken();

            if (token != null)
            {
                request.Headers[Keys.Authorization] = string.Format(CultureInfo.InvariantCulture, Messages.TokenAuthorizationMessageFormat, token);
            }
        }
    }
}
