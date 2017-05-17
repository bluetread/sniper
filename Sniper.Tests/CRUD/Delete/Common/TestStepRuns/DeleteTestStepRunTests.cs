using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.TestStepRuns
{
    public class DeleteTestStepRunTests 
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
