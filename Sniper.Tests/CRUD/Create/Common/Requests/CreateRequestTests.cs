using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Requests
{
    public class CreateRequestTests
    {
        [Fact]
        public void RequestThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Requests);

            var request = new Request();
        }
    }
}
