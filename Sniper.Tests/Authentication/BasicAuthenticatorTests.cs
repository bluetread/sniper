using Sniper.Configuration;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System.Net;
using Xunit;

namespace Sniper.Tests.Authentication
{
    public class BasicAuthenticatorTests
    {
        public class TheAuthenticateMethod
        {
            [Fact]
            public void VerifyBasicAuthenticationInvalidPassword()
            {
                var configData = ConfigurationData.Instance;
                configData.Credentials.Password = "This is not the correct password";

                var client = new TargetProcessClient(new BasicAuthenticator(configData.SiteInfo, configData.Credentials))
                {
                    ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories, true)
                };
                var data = client.GetSiteData<string>();
                var error = data.HttpResponse.IsError;
                Assert.True(error);
                Assert.True(data.HttpResponse.StatusCode == HttpStatusCode.Unauthorized);
            }

            [Fact]
            public void VerifyBasicAuthenticationValidPasswordFromConfigurationFile()
            {
                var client = new TargetProcessClient(new BasicAuthenticator())
                {
                    ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories, true)
                };
                var data = client.GetSiteData<string>();
                var error = data.HttpResponse.IsError;
                Assert.False(error);
                Assert.True(data.HttpResponse.StatusCode == HttpStatusCode.OK);
            }

#if false
             [Fact]
            public void VerifyBasicAuthenticationInvalidPassword()
            {
                var client = new TargetProcessClient(new BasicAuthenticator())
                {
                    ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories, true)
                };
                var data = client.GetSiteData();
                //authenticator.SiteInfo.Route = "UserStories";
                //var result = ApiSiteHelpers.GetSiteData(authenticator);
                var error = data.HttpResponse.IsError;
                //var data = result.Body;

                //authenticator.Authenticate(authenticator.ApiSiteInfo, authenticator.Credentials);
            }

            [Fact]
            public void SetsRequestHeaderForToken()
            {
                var authenticator = new BasicAuthenticator();
                var request = new Request();

                authenticator.Authenticate(request, new Credentials("that-creepy-dude", "Fahrvergnügen"));

                Assert.Contains("Authorization", request.Headers.Keys);
                Assert.Equal("Basic dGhhdC1jcmVlcHktZHVkZTpGYWhydmVyZ27DvGdlbg==", request.Headers["Authorization"]);
            }

            [Fact]
            public void EnsuresArgumentsNotNull()
            {
                var authenticator = new BasicAuthenticator();

                Assert.Throws<ArgumentNullException>(() => authenticator.Authenticate(new Request(), null));
                Assert.Throws<ArgumentNullException>(() => authenticator.Authenticate(null, new Credentials("x", "y")));
                Assert.Throws<ArgumentNullException>(() => authenticator.Authenticate(null, new Credentials("token")));
            }
#endif
        }
    }
}