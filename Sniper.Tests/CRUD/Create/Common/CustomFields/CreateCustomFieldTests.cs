using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.CustomFields
{
    public class CreateCustomFieldTests
    {
        [Fact]
        public void CreateCustomFieldThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.CustomFields);

            var customField = new CustomField();
        }
    }
}
