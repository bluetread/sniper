using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.TeamMembers
{
    public class ReadTeamMemberTests
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
