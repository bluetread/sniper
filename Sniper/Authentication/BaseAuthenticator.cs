using Sniper.Configuration;
using Sniper.Http;
using Sniper.Net;
using System.Collections.Generic;
using System.Net;
using ICredentials = Sniper.Http.ICredentials;

namespace Sniper
{
    public abstract class BaseAuthenticator : IAuthenticationHandler
    {
        public ISiteInfo SiteInfo { get; }
        public ICredentials Credentials { get; }
        public virtual System.Net.ICredentials NetworkCredentials { get; } = CredentialCache.DefaultCredentials;
        public virtual Dictionary<string, string> AuthenticationParameters { get; } = new Dictionary<string, string>();

        protected BaseAuthenticator() : this(ConfigurationData.Instance)
        {
            ServicePointManager.SecurityProtocol = Security.DefaultSecurityProtocolType; ;
        }

        protected BaseAuthenticator(IConfigurationData configurationData)
        {
            Ensure.ArgumentNotNull(nameof(configurationData), configurationData);

            SiteInfo = configurationData.SiteInfo;
            Credentials = configurationData.Credentials;
        }

        protected BaseAuthenticator(ISiteInfo siteInfo, ICredentials credentials) : this()
        {
            Ensure.ArgumentNotNull(nameof(siteInfo), siteInfo);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);

            SiteInfo = siteInfo;
            Credentials = credentials;
        }
    }
}