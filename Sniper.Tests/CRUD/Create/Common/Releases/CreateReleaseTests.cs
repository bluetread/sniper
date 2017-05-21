using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Releases
{
    public class CreateReleaseTests
    {
        [Fact]
        public void CreateReleaseThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Releases);

            var release = new Release();
        }
    }
}
