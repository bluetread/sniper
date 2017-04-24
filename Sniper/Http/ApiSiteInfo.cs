using System.Collections.Generic;
using System.Net.Http;

namespace Sniper.Http
{
    public class ApiSiteInfo : SiteInfo, IApiSiteInfo
    {
        public HttpMethod Method { get; set; } 
        public Dictionary<string, string> Parameters { get; } 
        public string Route { get; set; }

        public ApiSiteInfo(ISiteInfo siteInfo) : this(siteInfo, null) {}
        public ApiSiteInfo(ISiteInfo siteInfo, string route) : this(siteInfo, route, new Dictionary<string, string>()) {}
        public ApiSiteInfo(ISiteInfo siteInfo, string route, Dictionary<string, string> parameters) : this(siteInfo, route, parameters, HttpMethod.Get) {}

        public ApiSiteInfo(ISiteInfo siteInfo, string route, Dictionary<string, string> parameters, HttpMethod method)
        {
            Ensure.ArgumentNotNull(nameof(siteInfo), siteInfo);
            Ensure.ArgumentNotNull(nameof(method), method);

            BaseUrl = siteInfo.BaseUrl;
            HostName = siteInfo.HostName;
            IsApiIncluded = siteInfo.IsApiIncluded;
            IsVersionIncluded = siteInfo.IsVersionIncluded;
            IsVersionLetterIncluded = siteInfo.IsVersionLetterIncluded;
            Method = method;
            Parameters = parameters;
            Port = siteInfo.Port;
            Route = route;
            Version = siteInfo.Version;
        }
    }
}
