using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using System.Net;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Bugs
{
    public class DeleteBugTests
    {
        [Fact]
        public void DeleteBugWithInvalidIdThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Bugs)
            };

            var data = client.DeleteData<Bug>(2);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Null(data.Data);
            Assert.Equal(data.HttpResponse.StatusCode, HttpStatusCode.NotFound);
        }

        [Fact]
        public void CreateBugAndThenDeleteItSucceeds()
        {
            //Create a bug
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Bugs)
            };

            var bug = new Bug
            {
                Name = $"Sample Create From Code Bug - {DateTime.Now}",
                Project = new Project { Id = 194 }
            };
            var data = client.CreateData<Bug>(bug);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
            Assert.NotNull(data.Data.Project);
            Assert.NotNull(data.Data.Project.Id);

            var createdId = data.Data.Id;
            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);

            var result = client.DeleteData<Bug>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);
            Assert.Equal(createdId, result.Data.Id);
            Assert.Null(result.Data.Project);
        }
    }
}
