using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Iterations 
{ 
    public class IterationTests 
     { 
        [Fact] 
        public void IterationThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Iterations) 
            }; 
            var iteration = new Iteration 
            { 
            }; 
        } 
    } 
} 
