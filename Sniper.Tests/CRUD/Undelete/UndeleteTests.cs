using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Sniper.Tests.CRUD.Create;
using Xunit;

namespace Sniper.Tests.CRUD.Undelete
{
    public class UndeleteTests
    {
        [Fact]
        public void UnDeleteProjectWithValidIdSucceeds()
        {
            var client = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects) };
            // First, Create a project the project

            var data = CreateCommonMethods.GetNewProject(client);
            var createdId = data.Data.Id;

            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);

            // Then, Delete it
            var result = client.DeleteData<Project>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);

            // Then undelete the project
            var undeleteClient = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Undelete) };
            var undeleteProjectData = undeleteClient.UndeleteProjectData((int)createdId);

            Assert.NotNull(undeleteProjectData);
            Assert.False(undeleteProjectData.HttpResponse.IsError);

        }
    }
}
