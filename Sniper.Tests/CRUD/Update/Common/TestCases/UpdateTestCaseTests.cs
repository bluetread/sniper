using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.TestCases
{
    public class UpdateTestCaseTests
    { 
        [Fact] 
        public void TestCaseThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TestCases) 
            }; 
            var testCase = new TestCase 
            { 
            }; 
        } 
    } 
} 
