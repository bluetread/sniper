using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Roles
{
    public class CreateRoleTests
    {
        [Fact]
        public void CreateRoleThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Roles);

            var role = new Role();
        }
    }
}
