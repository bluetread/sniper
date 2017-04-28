using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using Xunit;

namespace Sniper.Tests.CRUD.Read
{
    public class ReadTests
    {
        [Fact]
        public void ReadTimeReturnsData()
        {
            var client = new TargetProcessClient(true)
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Times, true)
            };
            var data = client.GetData<Time>();
            var error = data.HttpResponse.IsError;
            Assert.False(error);
            Assert.True(data.HttpResponse.StatusCode == HttpStatusCode.OK);
            var times = data.DataCollection;
            Assert.NotNull(times);
        }

        [Fact]
        public void ReadUserStoryReturnsData()
        {
            var client = new TargetProcessClient(true)
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories, true) { CustomFilter = "&where=id eq 205" }
            };
            var data = client.GetData<UserStory>();
            var error = data.HttpResponse.IsError;
            Assert.False(error);
            Assert.True(data.HttpResponse.StatusCode == HttpStatusCode.OK);
            var stories = data.DataCollection;
            Assert.NotNull(stories);
            Assert.True(stories.Count == 1);
            var story = stories.First();
            Assert.True(story.GetType() == typeof(UserStory));
            Assert.True(story.Id == 205);
        }

        [Fact]
        public void ReadUserStoriesReturnsData()
        {
            var client = new TargetProcessClient(true)
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories, true)
            };
            var data = client.GetData<Collection<UserStory>>();
            var error = data.HttpResponse.IsError;
            Assert.False(error);
            Assert.True(data.HttpResponse.StatusCode == HttpStatusCode.OK);
        }
    }
}