using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Sniper.Http;
using static Sniper.Constants;

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
        ///See the <a href="http://developer.github.com/v3/#basic-authentication">Basic Authentication documentation</a> for more information.
        ///</remarks>
        public void Authenticate(IRequest request, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(Authentication.Request, request);
            Ensure.ArgumentNotNull(Authentication.Credentials, credentials);
            Ensure.ArgumentNotNull(Authentication.CredentialsLogin, credentials.Login);

            Debug.Assert(credentials.Password != null, Authentication.Messages.EmptyPassword);

            var header = string.Format(CultureInfo.InvariantCulture, Authentication.Messages.BasicAuthorizationMessageFormat, 
                Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, 
                Application.Messages.StandardKeyValueFormat, credentials.Login, credentials.Password))));

            request.Headers[Authentication.Keys.Authorization] = header;
        }
    }
}
