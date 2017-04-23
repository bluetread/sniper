using System;
using NSubstitute;
using Sniper.Configuration;
using Sniper.Http;
using Sniper.Tests.Fixtures;
using Xunit;
using static Sniper.Authentication.AuthenticationKeys;

namespace Sniper.Tests.Authentication
{
    public class AuthenticationFixture : IDisposable
    {
        public readonly ConfigurationData ConfigData = ConfigurationData.Instance;

        public void Dispose()
        {
        }
    }

    public class TokenAuthenticatorTests : IClassFixture<AuthenticationFixture>
    {
        public class TheAuthenticateMethod 
        {
            private readonly AuthenticationFixture _authenticationFixture;

            public TheAuthenticateMethod(AuthenticationFixture authenticationFixture)
            {
                _authenticationFixture = authenticationFixture;
            }

            [Fact]
            public void SetsRequestHeaderForAccessToken()
            {
                var authenticator = new AccessTokenAuthenticator();
                var request = new Request();

                authenticator.Authenticate(new Credentials(AuthenticationTokenType.AccessToken, "abcda1234a"));

                Assert.Contains(Keys.Authorization, request.Headers.Keys);
                Assert.Equal("Token abcda1234a", request.Headers[Keys.Authorization]);
            }

            [Fact]
            public void SetsRequestHeaderForServiceToken()
            {
                var authenticator = new ServiceTokenAuthenticator();
                var request = new Request();

                authenticator.Authenticate(TODO, TODO, new Credentials(AuthenticationTokenType.ServiceToken, "abcda1234a"));

                Assert.Contains(Keys.Authorization, request.Headers.Keys);
                Assert.Equal("Token abcda1234a", request.Headers[Keys.Authorization]);
            }

            [Fact]
            public void EnsuresCredentialsAreOfTheRightTypeForAccessToken()
            {
                var authenticator = new AccessTokenAuthenticator();
                var request = new Request();

                Assert.Throws<InvalidOperationException>(() =>
                    authenticator.Authenticate(TODO, TODO, new Credentials("login", "password")));
            }

            [Fact]
            public void EnsuresCredentialsAreOfTheRightTypeForServiceToken()
            {
                var authenticator = new ServiceTokenAuthenticator();
                var request = new Request();

                Assert.Throws<InvalidOperationException>(() =>
                    authenticator.Authenticate(TODO, TODO, new Credentials("login", "password")));
            }

            [Fact]
            public void EnsuresArgumentsNotNullForAccessToken()
            {
                var authenticator = new AccessTokenAuthenticator();
                Assert.Throws<ArgumentNullException>(() => authenticator.Authenticate(TODO, TODO, Credentials.CookieCredentials));
                Assert.Throws<ArgumentNullException>(() =>
                    authenticator.Authenticate(TODO, TODO, null));
            }

            [Fact]
            public void EnsuresArgumentsNotNullForServiceToken()
            {
                var authenticator = new ServiceTokenAuthenticator();
                Assert.Throws<ArgumentNullException>(() => authenticator.Authenticate(TODO, TODO, Credentials.CookieCredentials));
                Assert.Throws<ArgumentNullException>(() =>
                    authenticator.Authenticate(TODO, TODO, null));
            }

            [Fact]
            public void BasicAccessTokenAuthenticatorTest()
            {
                var configData = ConfigurationData.Instance.SiteInfo;
                var authenticator = new AccessTokenAuthenticator(configData);
            }
        }
    }
}
