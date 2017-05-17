using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.TestCaseRuns
{
    public class ReadTestCaseRunTests
    { 
        [Fact] 
        public void TestCaseRunThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TestCaseRuns) 
            }; 
            var testCaseRun = new TestCaseRun 
            { 
            }; 
        } 
    } 
} 
