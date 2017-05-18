using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TestSteps
{
    public class CreateTestStepTests
    {
        [Fact]
        public void TestStepThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TestSteps);

            var testStep = new TestStep();
        }
    }
}
