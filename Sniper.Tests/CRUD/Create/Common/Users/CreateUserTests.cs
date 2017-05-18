using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Users
{
    public class CreateUserTests
    {
        [Fact]
        public void UserThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Users);
            var user = new User();
        }
    }
}
