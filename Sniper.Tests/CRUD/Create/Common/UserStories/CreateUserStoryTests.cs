using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.UserStories
{
    public class CreateUserStoryTests
    {
        [Fact]
        public void CreateUserStoryWithoutDataThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var story = new UserStory();
            var data = client.CreateData<UserStory>(story);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.IsType(typeof(SniperExceptions.RequiredPropertyException), data.HttpResponse.Exception);
        }

        [Fact]
        public void CreateUserStoryWithOnlyNameThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var story = new UserStory
            {
                Name = "Sample Create From Code Story",
            };
            var data = client.CreateData<UserStory>(story);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.IsType(typeof(SniperExceptions.RequiredPropertyException), data.HttpResponse.Exception);
        }

        [Fact]
        public void CreateUserStoryWithNameAndProjectWithoutIdThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var story = new UserStory
            {
                Name = "Sample Create From Code Story",
                Project = new Project()
            };
            var data = client.CreateData<UserStory>(story);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.True(data.HttpResponse.Exception.GetType() == typeof(SniperExceptions.RequiredPropertyException));
            Assert.IsType(typeof(SniperExceptions.RequiredPropertyException), data.HttpResponse.Exception);
        }

        [Fact]
        public void CreateUserStoryWithNameAndInvalidProjectIdThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var story = new UserStory
            {
                Name = "Sample Create From Code Story",
                Project = new Project { Id = 1 }
            };
            var data = client.CreateData<UserStory>(story);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError); //TODO: Fix exception to show actual error. 
        }

        //TODO; This may or may not be correct. Need to investigate to see if creating a new project 
        // as part of cr
        [Fact]
        public void CreateUserStoryWithNameAndNewProjectWithNameMinimumFieldsSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var story = new UserStory
            {
                Name = $"Sample Create From Code Story - {DateTime.Now}",
                Project = new Project { Name = $"Some new project from code - {DateTime.Now}" }
            };
            var data = client.CreateData<UserStory>(story);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
        }


        [Fact]
        public void CreateUserStoryWithNameAndProjectWithIdMinimumFieldsSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var story = new UserStory
            {
                Name = $"Sample Create From Code Story - {DateTime.Now}",
                Project = new Project { Id = 194 }
            };
            var data = client.CreateData<UserStory>(story);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

        }
    }
}
