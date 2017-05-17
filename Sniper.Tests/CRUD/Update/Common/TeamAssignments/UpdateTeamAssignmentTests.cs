using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.TeamAssignments
{
    public class UpdateTeamAssignmentTests
    { 
        [Fact] 
        public void TeamAssignmentThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TeamAssignments) 
            }; 
            var teamAssignment = new TeamAssignment 
            { 
            }; 
        } 
    } 
} 
