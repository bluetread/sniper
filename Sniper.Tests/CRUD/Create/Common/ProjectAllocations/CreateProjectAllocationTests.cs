using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.ProjectAllocations
{
    public class CreateProjectAllocationTests
    {
        [Fact]
        public void CreateProjectAllocationThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.ProjectAllocations);

            var projectAllocation = new ProjectAllocation();
        }
    }
}
