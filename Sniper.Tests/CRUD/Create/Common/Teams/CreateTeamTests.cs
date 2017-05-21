using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Teams
{
    public class CreateTeamTests
    {
        [Fact]
        public void CreateTeamThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Teams);

            var team = new Team();
        }
    }
}
