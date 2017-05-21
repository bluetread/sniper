using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Sniper.Tests.CRUD.Create;
using System.Net;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Projects
{
    public class DeleteProjectTests
    {
        [Fact]
        public void DeleteProjectWithInvalidIdThrowsError()
        {
            var client = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects) };

            var data = client.DeleteData<Project>(220);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Null(data.Data);
            Assert.Equal(data.HttpResponse.StatusCode, HttpStatusCode.NotFound);
        }

        [Fact]
        public void CreateProjectAndThenDeleteItSucceeds()
        {
            //Create a project
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects)
            };

            var data = CreateCommonMethods.GetNewProject(client);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            var createdId = data.Data.Id;
            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);

            // Delete the project
            var result = client.DeleteData<Project>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);
            Assert.Equal(createdId, result.Data.Id);
        }


    }
}
