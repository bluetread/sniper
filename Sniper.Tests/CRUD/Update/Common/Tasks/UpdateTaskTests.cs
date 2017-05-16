using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Tasks
{
    public class UpdateTaskTests
    {
        [Fact]
        public void CreateTaskThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tasks)
            };
            var task = new Task();
            var data = client.CreateData<Task>(task);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateTaskWithNameThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tasks)
            };
            var task = new Task
            {
                Name = $"Sample Task From Code - {DateTime.Now}"
            };
            var data = client.CreateData<Task>(task);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateTaskWithNameAndProjectIdWithoutUserStoryThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tasks)
            };
            var task = new Task
            {
                Name = $"Sample Task From Code - {DateTime.Now}",
                Project = new Project { Id = 194 }
            };
            var data = client.CreateData<Task>(task);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }


        [Fact]
        public void CreateTaskWithNameAndUserStoryIdWithoutProjectThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tasks)
            };
            var task = new Task
            {
                Name = $"Sample Task From Code - {DateTime.Now}",
                UserStory = new UserStory { Id = 204 }
            };
            var data = client.CreateData<Task>(task);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }

        [Fact]
        public void UpdateTaskWithMinimumDataSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tasks)
            };

            var originalName = $"Sample Task From Code - {DateTime.Now}";

            var task = new Task
            {
                Name = originalName,
                Project = new Project { Id = 194 },
                UserStory = new UserStory { Id = 204 }
            };

            var data = client.CreateData<Task>(task);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            var newName = $"Sample Modified Task From Code - {DateTime.Now}";
            var newTask = new Task { Id = data.Data.Id, Project = data.Data.Project, UserStory = data.Data.UserStory, Name = newName };
            var newData = client.UpdateData<Task>(newTask);

            // Verify name changed
            Assert.NotEqual(newData.Data.Name, originalName);
            Assert.Equal(newData.Data.Name, newName);

            // Verify ID did NOT change
            Assert.Equal(data.Data.Id, newData.Data.Id);
        }
    }
}
