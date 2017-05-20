using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TestCases
{
    public class CreateTestCaseTests
    {
        [Fact]
        public void CreateTestCaseThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TestCases);

            var testCase = new TestCase();
        }
    }
}
