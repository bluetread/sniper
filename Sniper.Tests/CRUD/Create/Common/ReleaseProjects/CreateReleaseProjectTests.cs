using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.ReleaseProjects
{
    public class CreateReleaseProjectTests
    {
        [Fact]
        public void CreateReleaseProjectThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.ReleaseProjects);

            var releaseProject = new ReleaseProject();
        }
    }
}
