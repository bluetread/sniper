using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create
{
    public class CreateTests
    {
        [Fact]
        public void CreateUserStoryAddsData()
        {
            var client = new TargetProcessClient()
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories) 
            };
            var story = new UserStory { Name = "Sample Create From Code Story", Feature = new Feature { Id = 203 } };

            var data = client.CreateData<UserStory>(story);

        }
    }
}
