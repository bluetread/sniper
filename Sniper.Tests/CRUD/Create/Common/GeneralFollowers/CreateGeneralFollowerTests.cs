using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.GeneralFollowers
{
    public class CreateGeneralFollowerTests
    {
        [Fact]
        public void CreateGeneralFollowerThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.GeneralFollowers);

            var generalFollower = new GeneralFollower();
        }
    }
}
