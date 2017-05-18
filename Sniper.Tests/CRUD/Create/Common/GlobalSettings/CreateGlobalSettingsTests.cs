using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.GlobalSettings
{
    public class CreateGlobalSettingsTests
    {
        [Fact]
        public void GlobalSettingsThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.GlobalSettings);

            var globalSettings = new Sniper.Common.GlobalSettings();
        }
    }
}
