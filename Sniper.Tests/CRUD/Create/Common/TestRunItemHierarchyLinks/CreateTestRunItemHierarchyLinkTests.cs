using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TestRunItemHierarchyLinks
{
    public class CreateTestRunItemHierarchyLinkTests
    {
        [Fact]
        public void TestRunItemHierarchyLinkThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TestRunItemHierarchyLinks);

            var testRunItemHierarchyLink = new TestRunItemHierarchyLink();
        }
    }
}
