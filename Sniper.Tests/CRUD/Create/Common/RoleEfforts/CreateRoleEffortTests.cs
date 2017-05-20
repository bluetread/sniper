using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.RoleEfforts
{
    public class CreateRoleEffortTests
    {
        [Fact]
        public void CreateRoleEffortThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.RoleEfforts);

            var roleEffort = new RoleEffort();
        }
    }
}
