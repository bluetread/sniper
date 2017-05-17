using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.TestRunItemHierarchyLinks
{
    public class ReadTestRunItemHierarchyLinkTests
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
