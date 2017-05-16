using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.TestStepRuns
{
    public class ReadTestStepRunTests
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
