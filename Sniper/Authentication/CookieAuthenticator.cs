using Sniper.Http;

namespace Sniper
{
    
    internal class CookieAuthenticator : IAuthenticationHandler
    {
        ///<summary>
        ///Authenticate a request using cookies. This should work as long as
        ///you are already logged into a TargetProcess account.
        ///</summary>
        ///<param name="request">The request to authenticate (Optional/null)</param>
        ///<param name="credentials">The credentials to attach to the request(Optional/null)</param>
        ///<remarks>
        ///See the <a href="https://dev.targetprocess.com/docs/authentication#section-cookie-authentication">Cookie Authentication documentation</a> for more information. 
        ///</remarks>
        public void Authenticate(IRequest request, ICredentials credentials)
        {
            // Do nothing
        }
    }
}
