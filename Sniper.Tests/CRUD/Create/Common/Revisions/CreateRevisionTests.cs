using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Revisions
{
    public class CreateRevisionTests
    {
        [Fact]
        public void CreateRevisionThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Revisions);

            var revision = new Revision();
        }
    }
}
