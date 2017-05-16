using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TeamMembers 
{ 
    public class TeamMemberTests 
     { 
        [Fact] 
        public void TeamMemberThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TeamMembers) 
            }; 
            var teamMember = new TeamMember 
            { 
            }; 
        } 
    } 
} 
