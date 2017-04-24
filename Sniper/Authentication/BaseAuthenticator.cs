using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Sniper.Configuration;
using Sniper.Http;
using Sniper.TargetProcess;
using ICredentials = Sniper.Http.ICredentials;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    public abstract class BaseAuthenticator : IAuthenticationHandler
    {
        public IApiSiteInfo ApiSiteInfo { get; }
        public ICredentials Credentials { get; }
        protected virtual KeyValuePair<string, string> ResponseFormatParameter { get; }
        protected virtual Dictionary<string, string> DefaultQueryParameters { get; }

        [SuppressMessage(Categories.Globalization, MessageAttributes.NormalizeStringsToUppercase, Justification = Justifications.LowercaseValueExpected)]
        protected BaseAuthenticator()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ApiSiteInfo = new ApiSiteInfo(ConfigurationData.Instance.SiteInfo);
            Credentials = ConfigurationData.Instance.Credentials;

            var format = (ApiSiteInfo.IsJsonFormat ? ResponseFormat.Json : ResponseFormat.Xml).ToString().ToLowerInvariant();
            ResponseFormatParameter = new KeyValuePair<string, string>(QueryParameters.Format, format);
            DefaultQueryParameters = new Dictionary<string, string> {{ QueryParameters.Format, format }};
        }

        protected BaseAuthenticator(IApiSiteInfo apiSiteInfo, ICredentials credentials) : this()
        {
            Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);

            ApiSiteInfo = apiSiteInfo;
            Credentials = credentials;
        }

        //[SuppressMessage(Categories.Security, MessageAttributes.SealMethodsThatSatisfyPrivateInterfaces)]
        //public virtual void Authenticate(IApiSiteInfo apiSiteInfo, ICredentials credentials)
        //{
        //    Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
        //    Ensure.ArgumentNotNull(nameof(credentials), credentials);
        //}
    }
}
