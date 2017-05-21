using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TeamProjects
{
    public class CreateTeamProjectTests
    {
        [Fact]
        public void CreateTeamProjectThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TeamProjects);

            var teamProject = new TeamProject();
        }
    }
}
