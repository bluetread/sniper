using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Iterations
{
    public class ReadIterationTests
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
