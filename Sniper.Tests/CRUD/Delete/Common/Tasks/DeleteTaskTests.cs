using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using System.Net;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Tasks
{
    public class DeleteTaskTests
    {
        [Fact]
        public void DeleteTaskWithInvalidIdThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tasks)
            };

            var data = client.DeleteData<Task>(2);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Null(data.Data);
            Assert.Equal(data.HttpResponse.StatusCode, HttpStatusCode.NotFound);
        }

        [Fact]
        public void CreateTaskAndThenDeleteItSucceeds()
        {
            //Create a task
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tasks)
            };

            var task = new Task
            {
                Name = $"Sample Task From Code - {DateTime.Now}",
                Project = new Project { Id = 194 },
                UserStory = new UserStory { Id = 204 }
            };

            var data = client.CreateData<Task>(task);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            var createdId = data.Data.Id;
            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);
            Assert.NotNull(data.Data.Project);
            Assert.NotNull(data.Data.UserStory);

            var result = client.DeleteData<Task>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);
            Assert.Equal(createdId, result.Data.Id);

            Assert.Null(result.Data.Project);
            Assert.Null(result.Data.UserStory);
        }
    }
}
