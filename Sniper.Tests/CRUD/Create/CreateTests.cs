using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System.Net.Http;
using Xunit;

namespace Sniper.Tests.CRUD.Create
{
    public class CreateTests
    {
        [Fact]
        public void CreateUserStoryAddsData()
        {
            var client = new TargetProcessClient(true)
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories) { Method = HttpMethod.Post }
            };
            var story = new UserStory { Name = "Sample Create From Code Story", Project = new Project { Id = 205 } };

            var data = client.CreateData<UserStory>(story);

        }
    }
}
