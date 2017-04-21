using System;
using NSubstitute;
using Sniper.Http;
using Xunit;
using static Sniper.Authentication.AuthenticationKeys;

namespace Sniper.Tests.Authentication
{
    public class TokenAuthenticatorTests
    {
        public class TheAuthenticateMethod
        {
            [Fact]
            public void SetsRequestHeaderForAccessToken()
            {
                var authenticator = new AccessTokenAuthenticator();
                var request = new Request();

                authenticator.Authenticate(request, new Credentials(AuthenticationTokenType.AccessToken, "abcda1234a"));

                Assert.Contains(Keys.Authorization, request.Headers.Keys);
                Assert.Equal("Token abcda1234a", request.Headers[Keys.Authorization]);
            }

            [Fact]
            public void SetsRequestHeaderForServiceToken()
            {
                var authenticator = new ServiceTokenAuthenticator();
                var request = new Request();

                authenticator.Authenticate(request, new Credentials(AuthenticationTokenType.ServiceToken, "abcda1234a"));

                Assert.Contains(Keys.Authorization, request.Headers.Keys);
                Assert.Equal("Token abcda1234a", request.Headers[Keys.Authorization]);
            }

            [Fact]
            public void EnsuresCredentialsAreOfTheRightTypeForAccessToken()
            {
                var authenticator = new AccessTokenAuthenticator();
                var request = new Request();

                Assert.Throws<InvalidOperationException>(() =>
                    authenticator.Authenticate(request, new Credentials("login", "password")));
            }

            [Fact]
            public void EnsuresCredentialsAreOfTheRightTypeForServiceToken()
            {
                var authenticator = new ServiceTokenAuthenticator();
                var request = new Request();

                Assert.Throws<InvalidOperationException>(() =>
                    authenticator.Authenticate(request, new Credentials("login", "password")));
            }

            [Fact]
            public void EnsuresArgumentsNotNullForAccessToken()
            {
                var authenticator = new AccessTokenAuthenticator();
                Assert.Throws<ArgumentNullException>(() => authenticator.Authenticate(null, Credentials.CookieCredentials));
                Assert.Throws<ArgumentNullException>(() =>
                    authenticator.Authenticate(Substitute.For<IRequest>(), null));
            }
            [Fact]
            public void EnsuresArgumentsNotNullForServiceToken()
            {
                var authenticator = new ServiceTokenAuthenticator();
                Assert.Throws<ArgumentNullException>(() => authenticator.Authenticate(null, Credentials.CookieCredentials));
                Assert.Throws<ArgumentNullException>(() =>
                    authenticator.Authenticate(Substitute.For<IRequest>(), null));
            }
        }
    }
}
