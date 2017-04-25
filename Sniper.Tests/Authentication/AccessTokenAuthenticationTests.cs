using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System.Net;
using Xunit;

namespace Sniper.Tests.Authentication
{
    public class AccessTokenAuthenticationTests
    {
        [Fact]
        public void VerifyAccessTokenInvalidTokenHasError()
        {
            var client = new TargetProcessClient(new AccessTokenAuthenticator("This is not the correct password or token"))
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories, true)
            };
            var data = client.GetSiteData();
            var error = data.HttpResponse.IsError;
            Assert.True(error);
            Assert.True(data.HttpResponse.StatusCode == HttpStatusCode.Unauthorized);
        }

        [Fact]
        public void VerifyAccessTokenWIthValidTokenPasses()
        {
            var client = new TargetProcessClient(new AccessTokenAuthenticator())
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories, true)
            };
            var data = client.GetSiteData();
            var error = data.HttpResponse.IsError;
            Assert.False(error);
            Assert.True(data.HttpResponse.StatusCode == HttpStatusCode.OK);
        }
    }
}
