using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.UserStories
{
    public class DeleteDeleteUserStoryTests
    {
        [Fact]
        public void DeleteUserStoryWithoutDataThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories)
            };

            var story = new UserStory();
        }
    }
}
