using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TeamAssignments 
{ 
    public class TeamAssignmentTests 
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
