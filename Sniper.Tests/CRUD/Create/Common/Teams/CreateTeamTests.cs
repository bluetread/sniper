using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Teams
{
    public class CreateTeamTests
    { 
        [Fact] 
        public void TeamThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Teams) 
            }; 
            var team = new Team 
            { 
            }; 
        } 
    } 
} 
