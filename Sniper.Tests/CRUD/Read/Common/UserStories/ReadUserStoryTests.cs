using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.UserStories
{
    public class ReadUserStoryTests
    {
        [Fact]
        public void ReadUserStoryWithoutDataThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var story = new UserStory();
            var data = client.GetData<UserStory>();
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.IsType(typeof(SniperExceptions.RequiredPropertyException), data.HttpResponse.Exception);
        }
    }
}
