using Sniper.Http;
using Sniper.TargetProcess;
using System.Collections.Generic;
using ICredentials = Sniper.Http.ICredentials;

namespace Sniper
{
    internal class AccessTokenAuthenticator : TokenAuthenticatorBase
    {
        protected override AuthenticationTokenType TokenType { get; set; } = AuthenticationTokenType.AccessToken;
        public override Dictionary<string, string> AuthenticationParameters => new Dictionary<string, string> { { AuthenticationTokenParameters.AccessToken, Credentials.Password } };

        public AccessTokenAuthenticator() { }

        public AccessTokenAuthenticator(string token) : base(token) { }

        public AccessTokenAuthenticator(ISiteInfo siteInfo, ICredentials credentials) : base(siteInfo, credentials) { }
    }
}