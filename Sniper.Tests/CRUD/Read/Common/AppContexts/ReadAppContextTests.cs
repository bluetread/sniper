using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.AppContexts
{
    public class ReadAppContextTests
    {
        [Fact]
        public void AppContextThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.AppContexts)
            };
            var appContext = new AppContext
            {
            };
            var data = client.CreateData<AppContext>(appContext);
            Assert.False(data.HttpResponse.IsError);
        }
    }
}
