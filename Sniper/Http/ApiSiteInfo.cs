using Sniper.TargetProcess.Routes;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using Sniper.Configuration;
using static Sniper.Http.HttpResponseFormats;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.Http
{
    public class ApiSiteInfo : IApiSiteInfo
    {
        public HttpMethod Method { get; set; } = HttpMethod.Get;
        [SuppressMessage(Categories.Usage, MessageAttributes.CollectionPropertiesShouldBeReadOnly)]
        public IDictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();
        private ResponseFormat _responseFormat;
        public ResponseFormat ResponseFormat
        {
            get => _responseFormat;
            set
            {
                _responseFormat = value;
                Parameters[ResponseFormatKeys.Format] = (value.ToLowerCase());
            }
        }

        public string Route { get; }

        [SuppressMessage(Categories.Usage, MessageAttributes.CollectionPropertiesShouldBeReadOnly)]
        public ICollection<string> Includes { get; set; } = new Collection<string>();
        [SuppressMessage(Categories.Usage, MessageAttributes.CollectionPropertiesShouldBeReadOnly)]
        public ICollection<string> Excludes { get; set; } = new Collection<string>();

        public ApiSiteInfo() {}

        private ApiSiteInfo(string route)
        {
            Ensure.ArgumentNotNull(nameof(route), route);
            Route = route;
        }

        private ApiSiteInfo(string route, HttpMethod httpMethod) : this(route)
        {
            Ensure.ArgumentNotNull(nameof(httpMethod), httpMethod);
            Method = httpMethod;
        }

        private ApiSiteInfo(string route, ResponseFormat responseFormat) : this(route)
        {
            Ensure.ArgumentNotNull(nameof(responseFormat), responseFormat);
            ResponseFormat = responseFormat;
        }

        private ApiSiteInfo(string route, bool useConfigFormat) : this(route)
        {
            ResponseFormat = useConfigFormat ? ConfigurationData.Instance.SiteInfo.DefaultResponseFormat : ResponseFormat.Default;
        }

        public ApiSiteInfo(TargetProcessRoutes.Route route) : this(route.ToString()) {}
        public ApiSiteInfo(TargetProcessRoutes.Route route, ResponseFormat responseFormat) : this(route.ToString(), responseFormat) {}
        public ApiSiteInfo(TargetProcessRoutes.Route route, bool useConfigFormat) : this(route.ToString(), useConfigFormat) {}
        public ApiSiteInfo(TargetProcessRoutes.Route route, HttpMethod httpMethod) : this(route.ToString(), httpMethod) { }

        public ApiSiteInfo(TargetProcessHistoryRoutes.HistoryRoute route) : this(route.ToString()) { }
        public ApiSiteInfo(TargetProcessHistoryRoutes.HistoryRoute route, ResponseFormat responseFormat) : this(route.ToString(), responseFormat) { }
        public ApiSiteInfo(TargetProcessHistoryRoutes.HistoryRoute route, bool useConfigFormat) : this(route.ToString(), useConfigFormat) { }
        public ApiSiteInfo(TargetProcessHistoryRoutes.HistoryRoute route, HttpMethod httpMethod) : this(route.ToString(), httpMethod) {}
    }
}
