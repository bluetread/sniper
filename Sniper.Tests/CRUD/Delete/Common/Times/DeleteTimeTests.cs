using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System.Net;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Times
{
    public class DeleteTimeTests
    {
        [Fact]
        public void DeleteTimeWithInvalidIdThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Times)
            };

            var data = client.DeleteData<Time>(2);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Null(data.Data);
            Assert.Equal(data.HttpResponse.StatusCode, HttpStatusCode.NotFound);
        }

        [Fact]
        public void CreateTimeAndThenDeleteItSucceeds()
        {
            //Create a Time
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Times)
            };

            var time = new Time();
            var data = client.CreateData<Time>(time);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            var createdId = data.Data.Id;
            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);

            var result = client.DeleteData<Time>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);
            Assert.Equal(createdId, result.Data.Id);
        }
    }
}
