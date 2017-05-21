using Sniper.Common;
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
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Tasks);

            var task = new Task();
            var data = client.CreateData<Task>(task);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateTaskWithNameThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Tasks);

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
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Tasks);

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
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Tasks);

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
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Tasks);

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

        [Fact]
        public void CreateTaskAsyncWithMinimumDataSucceeds()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Tasks);

            var task = new Task
            {
                Name = $"Sample Task From Code - {DateTime.Now}",
                Project = new Project { Id = 194 },
                UserStory = new UserStory { Id = 204 }
            };
            var data = client.CreateDataAsync<Task>(task);

            Assert.NotNull(data);
            Assert.NotNull(data.Result);
            Assert.False(data.Result.HttpResponse.IsError);
        }

        [Fact]
        public void CreateTaskHelperWithMinimumDataSucceeds()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Tasks);

            var task = new Task
            {
                Name = $"Sample Task From Code - {DateTime.Now}",
                Project = new Project { Id = 194 },
                UserStory = new UserStory { Id = 204 }
            };
            var data = ((TargetProcessClient)client).CreateTask(task);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateTaskAsyncHelperWithMinimumDataSucceeds()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Tasks);

            var task = new Task
            {
                Name = $"Sample Task From Code - {DateTime.Now}",
                Project = new Project { Id = 194 },
                UserStory = new UserStory { Id = 204 }
            };
            var data = ((TargetProcessClient)client).CreateTaskAsync(task);

            Assert.NotNull(data);
            Assert.NotNull(data.Result);
            Assert.False(data.Result.HttpResponse.IsError);
        }
    }
}
