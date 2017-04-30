using Sniper.Http;
using System.Net;
using ICredentials = Sniper.Http.ICredentials;

namespace Sniper
{
    ///<summary>
    ///Authenticate a request using the basic access authentication scheme
    ///</summary>
    ///<remarks>
    ///See the <a href="https://dev.targetprocess.com/docs/authentication#section-basic-authentication">Basic Authentication documentation</a> for more information.
    ///</remarks>
    public class BasicAuthenticator : BaseAuthenticator
    {
        public override System.Net.ICredentials NetworkCredentials => new NetworkCredential(Credentials.Login, Credentials.Password);

        public BasicAuthenticator() { }

        public BasicAuthenticator(ISiteInfo siteInfo, ICredentials credentials) : base(siteInfo, credentials) { }

        
    }
}