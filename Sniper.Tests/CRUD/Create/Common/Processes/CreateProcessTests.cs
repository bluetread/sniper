using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Processes
{
    public class CreateProcessTests
    {
        [Fact]
        public void ProcessThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Processes);

            var process = new Process();
        }
    }
}
