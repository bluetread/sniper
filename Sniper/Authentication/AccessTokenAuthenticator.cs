using System.Collections.Generic;
using Sniper.Http;
using Sniper.TargetProcess;
using static Sniper.WarningsErrors.MessageSuppression;
using ICredentials = Sniper.Http.ICredentials;

namespace Sniper
{
    internal class AccessTokenAuthenticator : TokenAuthenticatorBase
    {
        protected override AuthenticationTokenType TokenType { get; set; } = AuthenticationTokenType.AccessToken;

        protected override Dictionary<string, string> DefaultQueryParameters => new Dictionary<string, string>
        {
            { ResponseFormatParameter.Key, ResponseFormatParameter.Value } ,
            { QueryParameters.AccessToken, Credentials.Password }
        };

        public AccessTokenAuthenticator() {}

        [System.Diagnostics.CodeAnalysis.SuppressMessage(Categories.Usage, MessageAttributes.ReviewUnusedParameters)]
        public AccessTokenAuthenticator(IApiSiteInfo apiSiteInfo, ICredentials credentials) : base(apiSiteInfo, credentials) {}

        //public override void Authenticate(IApiSiteInfo apiSiteInfo, ICredentials credentials) 
        //{
        //    Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
        //    Ensure.ArgumentNotNull(nameof(credentials), credentials);

        //    base.Authenticate(apiSiteInfo, credentials);
        //    TokenParameter = new KeyValuePair<string, string>(QueryParameters.AccessToken, credentials.Password);
        //}
    }
}
