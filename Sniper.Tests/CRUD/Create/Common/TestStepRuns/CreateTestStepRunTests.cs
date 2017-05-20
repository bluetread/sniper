using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TestStepRuns
{
    public class CreateTestStepRunTests
    {
        [Fact]
        public void CreateTestStepRunThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TestStepRuns);

            var testStepRun = new TestStepRun();
        }
    }
}
