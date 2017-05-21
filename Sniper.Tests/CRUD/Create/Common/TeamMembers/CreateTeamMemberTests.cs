using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TeamMembers
{
    public class CreateTeamMemberTests
    {
        [Fact]
        public void CreateTeamMemberThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TeamMembers);
            var teamMember = new TeamMember();
        }
    }
}
