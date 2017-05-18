using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Builds
{
    public class CreateBuildTests
    {
        [Fact]
        public void BuildThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Builds);

            var build = new Build();
        }
    }
}
