using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.TeamProjectAllocations
{
    public class ReadTeamProjectAllocationTests
    { 
        [Fact] 
        public void TeamProjectAllocationThrowsError() 
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
