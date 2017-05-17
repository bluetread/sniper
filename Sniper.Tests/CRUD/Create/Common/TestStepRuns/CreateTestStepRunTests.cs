using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TestStepRuns
{
    public class CreateTestStepRunTests
    { 
        [Fact] 
        public void TestStepRunThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TestStepRuns) 
            }; 
            var testStepRun = new TestStepRun 
            { 
            }; 
        } 
    } 
} 
