using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TeamIterations 
{ 
    public class TeamIterationTests 
     { 
        [Fact] 
        public void TeamIterationThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TeamIterations) 
            }; 
            var teamIteration = new TeamIteration 
            { 
            }; 
        } 
    } 
} 
