using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.RequestTypes
{
    public class CreateRequestTypeTests
    {
        [Fact]
        public void CreateRequestTypeThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.RequestTypes);

            var requestType = new RequestType();
        }
    }
}
