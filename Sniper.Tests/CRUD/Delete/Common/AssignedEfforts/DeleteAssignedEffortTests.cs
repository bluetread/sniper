using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.AssignedEfforts
{
    public class DeleteAssignedEffortTests
    {
        [Fact]
        public void AssignedEffortThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.AssignedEfforts);

            var assignedEffort = new AssignedEffort();
        }
    }
}
