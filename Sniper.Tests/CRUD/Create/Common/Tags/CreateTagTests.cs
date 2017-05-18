using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Tags
{
    public class CreateTagTests
    {
        [Fact]
        public void TagThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Tags);

            var tag = new Tag();
        }
    }
}
