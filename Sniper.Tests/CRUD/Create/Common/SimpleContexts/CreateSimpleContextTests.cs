using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.SimpleContexts
{
    public class CreateSimpleContextTests
    {
        [Fact]
        public void CreateSimpleContextThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.SimpleContexts);

            var simpleContext = new SimpleContext();
        }
    }
}
