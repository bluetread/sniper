using Sniper.Http;
using Sniper.TargetProcess;
using System.Collections.Generic;

namespace Sniper
{
    internal abstract class TokenAuthenticatorBase : BaseAuthenticator
    {
        protected virtual AuthenticationTokenType TokenType { get; set; } = AuthenticationTokenType.ServiceToken;
        public override Dictionary<string, string> AuthenticationParameters => new Dictionary<string, string> { { AuthenticationTokenParameters.ServiceToken, Credentials.Password } };

        protected TokenAuthenticatorBase() {}

        protected TokenAuthenticatorBase(string token)
        {
            Credentials.Password = token;
        }

        protected TokenAuthenticatorBase(ISiteInfo siteInfo, ICredentials credentials) : base(siteInfo, credentials) {}
    }
}
