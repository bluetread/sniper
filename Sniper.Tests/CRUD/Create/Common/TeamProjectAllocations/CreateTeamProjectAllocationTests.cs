using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TeamProjectAllocations
{
    public class CreateTeamProjectAllocationTests
    {
        [Fact]
        public void CreateTeamProjectAllocationThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TeamProjectAllocations)
            };
            var teamProjectAllocation = new TeamProjectAllocation
            {
            };
        }
    }
}
