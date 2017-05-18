using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TestPlanRuns
{
    public class CreateTestPlanRunTests
    {
        [Fact]
        public void TestPlanRunThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TestPlanRuns);

            var testPlanRun = new TestPlanRun();
        }
    }
}
