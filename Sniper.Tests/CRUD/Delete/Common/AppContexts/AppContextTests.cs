using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.AppContexts
{
    public class DeleteAppContextTests
    {
        [Fact]
        public void AppContextThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.AppContexts);

            var appContext = new AppContext();
        }
    }
}
