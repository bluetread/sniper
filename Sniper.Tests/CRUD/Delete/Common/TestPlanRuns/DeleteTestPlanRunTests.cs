using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.TestPlanRuns
{
    public class DeleteTestPlanRunTests 
     { 
        [Fact] 
        public void TestPlanRunThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TestPlanRuns) 
            }; 
            var testPlanRun = new TestPlanRun 
            { 
            }; 
        } 
    } 
} 
