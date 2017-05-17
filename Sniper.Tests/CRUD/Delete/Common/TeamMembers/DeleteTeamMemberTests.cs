using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.TeamMembers
{
    public class DeleteTeamMemberTests 
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
