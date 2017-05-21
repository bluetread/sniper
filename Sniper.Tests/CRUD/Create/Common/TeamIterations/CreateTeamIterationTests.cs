using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TeamIterations
{
    public class CreateTeamIterationTests
    {
        [Fact]
        public void CreateTeamIterationThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TeamIterations);
            var teamIteration = new TeamIteration();
        }
    }
}
