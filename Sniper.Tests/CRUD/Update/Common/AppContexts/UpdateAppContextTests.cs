using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.AppContexts
{
    public class UpdateAppContextTests
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
