using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TeamAssignments
{
    public class CreateTeamAssignmentTests
    {
        [Fact]
        public void TeamAssignmentThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TeamAssignments);
            var teamAssignment = new TeamAssignment();
        }
    }
}
