using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Practices
{
    public class CreatePracticeTests
    {
        [Fact]
        public void CreatePracticeThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Practices);

            var practice = new Practice();
        }
    }
}
