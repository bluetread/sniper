using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.InboundAssignables
{
    public class CreateInboundAssignableTests
    {
        [Fact]
        public void CreateInboundAssignableThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.InboundAssignables);

            var inboundAssignable = new InboundAssignable();
        }
    }
}
