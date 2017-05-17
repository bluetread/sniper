using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using System.Net;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Epics
{
    public class DeleteEpicTests
    {
        [Fact]
        public void DeleteEpicWithInvalidIdThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Epics)
            };

            var data = client.DeleteData<Epic>(2);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Null(data.Data);
            Assert.Equal(data.HttpResponse.StatusCode, HttpStatusCode.NotFound);
        }

        [Fact]
        public void CreateEpicAndThenDeleteItSucceeds()
        {
            //Create an epic
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Epics)
            };

            var epic = new Epic
            {
                Name = $"Sample Epic From Code - {DateTime.Now}",
                Project = new Project { Id = 194 }
            };
            var data = client.CreateData<Epic>(epic);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
            Assert.NotNull(data.Data.Project);
            Assert.NotNull(data.Data.Project.Id);

            var createdId = data.Data.Id;
            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);

            var result = client.DeleteData<Epic>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);
            Assert.Equal(createdId, result.Data.Id);
            Assert.Null(result.Data.Project);
        }
    }
}