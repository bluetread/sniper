using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.GeneralUsers
{
    public class CreateGeneralUserTests
    {
        [Fact]
        public void CreateGeneralUserThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.GeneralUsers);

            var generalUser = new GeneralUser();
        }
    }
}
