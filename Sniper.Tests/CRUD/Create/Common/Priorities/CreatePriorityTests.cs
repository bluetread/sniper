using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Priorities
{
    public class CreatePriorityTests
    {
        [Fact]
        public void PriorityThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Priorities);

            var priority = new Priority();
        }
    }
}
