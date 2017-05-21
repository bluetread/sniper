using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Workflows
{
    public class CreateWorkflowTests
    {
        [Fact]
        public void CreateWorkflowThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Workflows);

            var workflow = new Workflow();
        }
    }
}
