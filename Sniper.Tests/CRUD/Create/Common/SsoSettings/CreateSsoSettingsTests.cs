using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.SsoSettings
{
    public class CreateSsoSettingsTests
    {
        [Fact]
        public void SsoSettingsThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.SsoSettings);

            var ssoSettings = new Sniper.Common.SsoSettings();
        }
    }
}
