using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Tasks
{
    public class CreateTaskTests
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
        public void CreateTaskWithMinimumDataSucceeds()
        {
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
        }
    }
}
