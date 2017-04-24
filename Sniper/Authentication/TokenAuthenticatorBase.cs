using System.Collections.Generic;
using Sniper.Http;
using Sniper.TargetProcess;

namespace Sniper
{
    internal abstract class TokenAuthenticatorBase : BaseAuthenticator
    {
        protected virtual AuthenticationTokenType TokenType { get; set; } = AuthenticationTokenType.ServiceToken;
        protected virtual KeyValuePair<string, string> TokenParameter { get;  }

        protected TokenAuthenticatorBase() {}

        protected TokenAuthenticatorBase(IApiSiteInfo apiSiteInfo, ICredentials credentials) : base(apiSiteInfo, credentials)
        {
            TokenParameter = new KeyValuePair<string, string>(QueryParameters.Token, credentials.Password);
        }

#if false
        public override void Authenticate(IApiSiteInfo apiSiteInfo, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);

            base.Authenticate(apiSiteInfo, credentials);
            TokenParameter = new KeyValuePair<string, string>(QueryParameters.Token, credentials.Password);
        }
#endif
    }
}
