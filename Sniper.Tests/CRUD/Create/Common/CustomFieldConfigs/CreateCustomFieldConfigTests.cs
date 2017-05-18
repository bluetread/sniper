using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.CustomFieldConfigs
{
    public class CreateCustomFieldConfigTests
    {
        [Fact]
        public void CustomFieldConfigThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.CustomFieldConfigs);

            var customFieldConfig = new CustomFieldConfig();
        }
    }
}
