using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Impediments
{
    public class CreateImpedimentTests
    {
        [Fact]
        public void ImpedimentThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Impediments);

            var impediment = new Impediment();
        }
    }
}
