using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.UserStories
{
    public class UpdateUserStoryTests
    {
        [Fact]
        public void UpdateUserStoryWithNameAndProjectWithIdMinimumFieldsSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var originalName = $"Sample Create From Code Story - {DateTime.Now}";
            var story = new UserStory
            {
                Name = originalName,
                Project = new Project { Id = 194 }
            };
            var data = client.CreateData<UserStory>(story);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            var newName = $"Sample Modified User Story From Code - {DateTime.Now}";

            var newStory = new UserStory { Id = data.Data.Id, Name = newName, Project = data.Data.Project };

            var newData = client.UpdateData<UserStory>(newStory);

            Assert.NotNull(newData);
            Assert.False(newData.HttpResponse.IsError);

            // Verify name changed
            Assert.NotEqual(newData.Data.Name, originalName);
            Assert.Equal(newData.Data.Name, newName);

            // Verify ID did NOT change
            Assert.Equal(data.Data.Id, newData.Data.Id);
        }


    }
}
