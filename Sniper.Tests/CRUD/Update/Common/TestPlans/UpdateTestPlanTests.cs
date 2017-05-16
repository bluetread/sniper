using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.TestPlans
{
    public class UpdateTestPlanTests
    { 
        [Fact] 
        public void TestPlanThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TestPlans) 
            }; 
            var testPlan = new TestPlan 
            { 
            }; 
        } 
    } 
} 
