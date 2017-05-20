using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Requesters
{
    public class CreateRequesterTests
    {
        [Fact]
        public void CreateRequesterThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Requesters);

            var requester = new Requester();
        }
    }
}
