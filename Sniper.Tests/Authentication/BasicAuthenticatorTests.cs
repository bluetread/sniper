using System.Net.Http;
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
                var authenticator = new BasicAuthenticator();
                authenticator.ApiSiteInfo.Route = "UserStories";
                authenticator.ApiSiteInfo.Parameters.Add("format","json");
                authenticator.ApiSiteInfo.Method = HttpMethod.Get;

                authenticator.Authenticate(authenticator.ApiSiteInfo, authenticator.Credentials);
            }

#if false
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