using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Roles
{
    public class CreateRoleTests
    {
        [Fact]
        public void RoleThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Roles);

            var role = new Role();
        }
    }
}
