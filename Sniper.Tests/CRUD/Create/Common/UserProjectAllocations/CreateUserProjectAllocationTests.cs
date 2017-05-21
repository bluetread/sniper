using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.UserProjectAllocations
{
    public class CreateUserProjectAllocationTests
    {
        [Fact]
        public void CreateUserProjectAllocationThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.ProjectAllocations);
            var userProjectAllocation = new UserProjectAllocation();
        }
    }
}
