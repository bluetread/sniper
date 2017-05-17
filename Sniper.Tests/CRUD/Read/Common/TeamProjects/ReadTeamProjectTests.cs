using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.TeamProjects
{
    public class ReadTeamProjectTests
    { 
        [Fact] 
        public void TeamProjectThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TeamProjects) 
            }; 
            var teamProject = new TeamProject 
            { 
            }; 
        } 
    } 
} 
