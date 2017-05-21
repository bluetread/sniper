using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Projects
{
    public class CreateProjectTests
    {
        [Fact]
        public void CreateProjectWithoutNameThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Projects);

            var project = new Project();
            var data = client.CreateData<Project>(project);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateProjectWithMinimumFieldsSucceeds()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Projects);
            var data = CreateCommonMethods.GetNewProject(client);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
        }
    }
}
