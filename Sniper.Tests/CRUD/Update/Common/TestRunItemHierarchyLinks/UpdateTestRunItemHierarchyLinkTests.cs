using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.TestRunItemHierarchyLinks
{
    public class UpdateTestRunItemHierarchyLinkTests
    { 
        [Fact] 
        public void TestRunItemHierarchyLinkThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.TestRunItemHierarchyLinks) 
            }; 
            var testRunItemHierarchyLink = new TestRunItemHierarchyLink 
            { 
            }; 
        } 
    } 
} 
