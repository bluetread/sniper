using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Times
{
    public class ReadTimeTests
    {
        [Fact]
        public void TimeThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Times)
            };
            var time = new Time
            {
            };
        }

        //TODO: Add logic to class to require data (at least user id and project id or story id?)
        [Fact]
        public void CreateTimeWithMinimumFieldsSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Times)
            };

            var time = new Time();
            var data = client.CreateData<Time>(time);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
        }
    }
}
