using System.Collections.Generic;
using System.Net.Http;

namespace Sniper.Http
{
    public class ApiSiteInfo : SiteInfo, IApiSiteInfo
    {
        public HttpMethod Method { get; set; }
        public Dictionary<string, string> Parameters { get; } = new Dictionary<string, string>();
        public string Route { get; set; }

        public ApiSiteInfo(ISiteInfo siteInfo)
        {
            Ensure.ArgumentNotNull(nameof(siteInfo), siteInfo);

            BaseUrl = siteInfo.BaseUrl;
            HostName = siteInfo.HostName;
            IsApiIncluded = siteInfo.IsApiIncluded;
            IsVersionIncluded = siteInfo.IsVersionIncluded;
            IsVersionLetterIncluded = siteInfo.IsVersionLetterIncluded;
            Port = siteInfo.Port;
            Version = siteInfo.Version;
        }
    }
}
