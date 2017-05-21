using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.MessageUniqueIds
{
    public class CreateMessageUniqueIdTests
    {
        [Fact]
        public void CreateMessageUniqueIdThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.MessageUniqueIds);

            var messageUniqueId = new MessageUniqueId();
        }
    }
}
