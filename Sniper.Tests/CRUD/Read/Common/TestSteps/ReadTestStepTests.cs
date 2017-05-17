using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.TestSteps
{
    public class ReadTestStepTests
    { 
        [Fact] 
        public void TestStepThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TestSteps) 
            }; 
            var testStep = new TestStep 
            { 
            }; 
        } 
    } 
} 
