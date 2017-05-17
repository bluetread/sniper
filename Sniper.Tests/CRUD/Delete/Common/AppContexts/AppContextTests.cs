using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.AppContexts
{
    public class DeleteAppContextTests
    {
        [Fact]
        public void AppContextThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.AppContexts)
            };
            var appContext = new AppContext
            {
            };
        }
    }
}
