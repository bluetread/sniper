using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Cultures
{
    public class CreateCultureTests
    {
        [Fact]
        public void CreateCultureThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Cultures);

            var culture = new Culture();
        }
    }
}
