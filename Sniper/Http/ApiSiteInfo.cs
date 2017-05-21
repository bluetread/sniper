using Sniper.TargetProcess.Routes;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.Http
{
    public class ApiSiteInfo : IApiSiteInfo
    {
        [SuppressMessage(Categories.Usage, MessageAttributes.CollectionPropertiesShouldBeReadOnly)]
        public IDictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();

        public ICollection<string> FieldList { get; set; } = new Collection<string>();
        public bool IsInclude { get; set; } = true;
        public string CustomFilter { get; set; }

        public string Route { get; }

        [SuppressMessage(Categories.Usage, MessageAttributes.CollectionPropertiesShouldBeReadOnly)]
        public ICollection<string> Includes { get; set; } = new Collection<string>();

        [SuppressMessage(Categories.Usage, MessageAttributes.CollectionPropertiesShouldBeReadOnly)]
        public ICollection<string> Excludes { get; set; } = new Collection<string>();

        public ApiSiteInfo() { }

        private ApiSiteInfo(string route)
        {
            Ensure.ArgumentNotNull(nameof(route), route);
            Route = route;
        }

        public ApiSiteInfo(TargetProcessRoutes.Route route) : this(route.ToString()) { }
        public ApiSiteInfo(TargetProcessHistoryRoutes.HistoryRoute route) : this(route.ToString()) { }
    }
}