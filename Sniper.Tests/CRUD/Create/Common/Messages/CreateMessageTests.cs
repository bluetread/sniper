using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Messages
{
    public class CreateMessageTests
    {
        [Fact]
        public void CreateMessageThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Messages);

            var message = new Message();
        }
    }
}
