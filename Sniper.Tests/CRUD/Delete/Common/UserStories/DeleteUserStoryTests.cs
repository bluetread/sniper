using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using System.Net;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.UserStories
{
    public class DeleteDeleteUserStoryTests
    {
        [Fact]
        public void DeleteUserStoryWithInvalidIdThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var data = client.DeleteData<UserStory>(2);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Null(data.Data);
            Assert.Equal(data.HttpResponse.StatusCode, HttpStatusCode.NotFound);
        }

        [Fact]
        public void CreateUserStoryAndThenDeleteItSucceeds()
        {
            //Create a story
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
            Assert.NotNull(data.Data.Project);
            Assert.NotNull(data.Data.Project.Id);

            var createdId = data.Data.Id;
            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);

            var result = client.DeleteData<UserStory>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);
            Assert.Equal(createdId, result.Data.Id);
            Assert.Null(result.Data.Project);
        }
    }
}
