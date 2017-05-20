using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Times
{
    public class CreateTimeTests
    {
        [Fact]
        public void CreateTimeThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Times);

            var time = new Time();
        }

        [Fact]
        public void CreateTimeWithMinimumFieldsSucceeds()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Times);

            var time = new Time();
            var data = client.CreateData<Time>(time);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
        }
    }
}
