using Sniper.Http;
using Sniper.TargetProcess.Routes;

namespace Sniper.Tests.CRUD
{
    public static class CommonMethods
    {
        public static ITargetProcessClient GetClientByRoute(TargetProcessRoutes.Route route)
        {
            var client = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(route) };
            return client;
        }
    }
}
