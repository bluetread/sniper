using System.Diagnostics.CodeAnalysis;
using System.Net;
using Sniper.Configuration;
using Sniper.Http;
using ICredentials = Sniper.Http.ICredentials;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    public abstract class BaseAuthenticator : IAuthenticationHandler
    {
        public IApiSiteInfo ApiSiteInfo { get; }
        public ICredentials Credentials { get; }

        protected BaseAuthenticator()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ApiSiteInfo = new ApiSiteInfo(ConfigurationData.Instance.SiteInfo);
            Credentials = ConfigurationData.Instance.Credentials;
        }

        protected BaseAuthenticator(IApiSiteInfo apiSiteInfo, ICredentials credentials) : this()
        {
            Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);

            ApiSiteInfo = apiSiteInfo;
            Credentials = credentials;
        }

        [SuppressMessage(Categories.Security, MessageAttributes.SealMethodsThatSatisfyPrivateInterfaces)]
        public virtual void Authenticate(IApiSiteInfo apiSiteInfo, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);
        }
    }
}
