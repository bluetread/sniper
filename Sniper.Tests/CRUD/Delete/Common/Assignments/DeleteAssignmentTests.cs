using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Assignments
{
    public class DeleteAssignmentTests
    {
        [Fact]
        public void AssignmentThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Assignments);

            var assignment = new Assignment();
        }
    }
}
