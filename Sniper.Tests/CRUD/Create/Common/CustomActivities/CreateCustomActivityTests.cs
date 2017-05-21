using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.CustomActivities
{
    public class CreateCustomActivityTests
    {
        [Fact]
        public void CreateCustomActivityThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.CustomActivities);

            var customActivity = new CustomActivity();
        }
    }
}
