using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Terms
{
    public class CreateTermTests
    {
        [Fact]
        public void CreateTermThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Terms);

            var term = new Term();
        }
    }
}
