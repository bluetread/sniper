using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TestPlans
{
    public class CreateTestPlanTests
    {
        [Fact]
        public void CreateTestPlanThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TestPlans);

            var testPlan = new TestPlan
            {
            };
        }
    }
}
