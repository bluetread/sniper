using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Assignables
{
    public class DeleteDeleteAssignableTests
    {
        [Fact]
        public void DeleteAssignableThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Assignables);

            var assignable = new Assignable();
        }
    }
}
