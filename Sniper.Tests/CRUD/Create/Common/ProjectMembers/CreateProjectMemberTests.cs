using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.ProjectMembers
{
    public class CreateProjectMemberTests
    {
        [Fact]
        public void ProjectMemberThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.ProjectMembers);

            var projectMember = new ProjectMember();
        }
    }
}
