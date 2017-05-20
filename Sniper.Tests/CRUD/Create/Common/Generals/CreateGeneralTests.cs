using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Generals
{
    public class CreateGeneralTests
    {
        [Fact]
        public void CreateGeneralThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Generals);

            var general = new General();
        }
    }
}
