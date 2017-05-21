using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.OutboundAssignables
{
    public class CreateOutboundAssignableTests
    {
        [Fact]
        public void CreateOutboundAssignableThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.OutboundAssignables);

            var outboundAssignable = new OutboundAssignable();
        }
    }
}
