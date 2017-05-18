using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Severities
{
    public class CreateSeverityTests
    {
        [Fact]
        public void SeverityThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Severities);

            var severity = new Severity();
        }
    }
}
