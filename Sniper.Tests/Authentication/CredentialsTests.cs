using System;
using Sniper.Http;
using Xunit;

namespace Sniper.Tests.Authentication
{
    public class CredentialsTests
    {
        public class TheAuthenticationTypeProperty
        {
            [Fact]
            public void ReturnsCookieForEmptyCtor()
            {
                var credentials = Credentials.CookieCredentials;
                Assert.Equal(AuthenticationType.Cookie, credentials.AuthenticationType);
            }

            [Fact]
            public void ReturnsBasicWhenProvidedLoginAndPassword()
            {
                var credentials = new Credentials("login", "password");
                Assert.Equal(AuthenticationType.Basic, credentials.AuthenticationType);
            }

            [Fact]
            public void ReturnsAccessTokenWhenProvidedTokenForAccessToken()
            {
                var credentials = new Credentials(AuthenticationTokenType.AccessToken, "token");
                Assert.Equal(AuthenticationType.AccessToken, credentials.AuthenticationType);
            }
            [Fact]
            public void ReturnsServiceTokenWhenProvidedTokenForServiceToken()
            {
                var credentials = new Credentials(AuthenticationTokenType.ServiceToken, "token");
                Assert.Equal(AuthenticationType.ServiceToken, credentials.AuthenticationType);
            }
        }

        public class TheLoginProperty
        {
            [Fact]
            public void IsSetFromCtor()
            {
                var credentials = new Credentials("login", "password");
                Assert.Equal("login", credentials.Login);
            }
        }

        public class ThePasswordProperty
        {
            [Fact]
            public void IsSetFromCtor()
            {
                var credentials = new Credentials("login", "password");
                Assert.Equal("password", credentials.Password);
            }
        }
        public class TheCtor
        {
            [Fact]
            public void EnsuresArgumentsNotNullNorEmpty()
            {
                Assert.Throws<ArgumentNullException>(() => new Credentials(AuthenticationTokenType.AccessToken, null));
                Assert.Throws<ArgumentNullException>(() => new Credentials(AuthenticationTokenType.ServiceToken, null));
                Assert.Throws<ArgumentNullException>(() => new Credentials(AuthenticationTokenType.AccessToken, " "));
                Assert.Throws<ArgumentNullException>(() => new Credentials(AuthenticationTokenType.ServiceToken, " "));
                Assert.Throws<ArgumentNullException>(() => new Credentials(null, "password"));
                Assert.Throws<ArgumentNullException>(() => new Credentials("login", null));
                Assert.Throws<ArgumentException>(() => new Credentials(" ", "Password"));
                Assert.Throws<ArgumentException>(() => new Credentials("login", " "));
            }
        }
    }
}
