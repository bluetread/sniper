using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.TeamProjects
{
    public class DeleteTeamProjectTests 
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
