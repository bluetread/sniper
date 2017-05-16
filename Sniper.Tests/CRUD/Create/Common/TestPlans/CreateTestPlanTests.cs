using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TestPlans 
{ 
    public class TestPlanTests 
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
