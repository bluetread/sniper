using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Programs
{
    public class CreateProgramTests
    {
        [Fact]
        public void CreateProgramThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Programs);

            var program = new Program();
        }
    }
}
