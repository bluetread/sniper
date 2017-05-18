using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.ExtendedContexts
{
    public class CreateExtendedContextTests
    {
        [Fact]
        public void ExtendedContextThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.ExtendedContexts);
            var extendedContext = new ExtendedContext();
        }
    }
}
