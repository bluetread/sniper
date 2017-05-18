using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.CustomRules
{
    public class CreateCustomRuleTests
    {
        [Fact]
        public void CustomRuleThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.CustomRules);

            var customRule = new CustomRule
            {
            };
        }
    }
}
