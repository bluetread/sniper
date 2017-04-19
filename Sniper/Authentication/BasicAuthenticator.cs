using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Sniper.Application.Messages;
using Sniper.Authentication;
using Sniper.Http;

namespace Sniper
{
    internal class BasicAuthenticator : IAuthenticationHandler
    {
        ///<summary>
        ///Authenticate a request using the basic access authentication scheme
        ///</summary>
        ///<param name="request">The request to authenticate</param>
        ///<param name="credentials">The credentials to attach to the request</param>
        ///<remarks>
        ///See the <a href="http://developer.github.com/v3/#basic-authentication">Basic Authentication documentation</a> for more information. //TODO: Replace with TargetProcess
        ///</remarks>
        public void Authenticate(IRequest request, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(HttpKeys.RequestParameters.Request, request);
            Ensure.ArgumentNotNull(AuthenticationKeys.Credentials, credentials);
            Ensure.ArgumentNotNull(AuthenticationKeys.CredentialsLogin, credentials.Login);

            Debug.Assert(credentials.Password != null, AuthenticationKeys.Messages.EmptyPassword);

            var header = string.Format(CultureInfo.InvariantCulture, AuthenticationKeys.Messages.BasicAuthorizationMessageFormat, 
                Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, 
                MessageKeys.StandardKeyValueFormat, credentials.Login, credentials.Password))));

            request.Headers[AuthenticationKeys.Keys.Authorization] = header;
        }
    }
}
