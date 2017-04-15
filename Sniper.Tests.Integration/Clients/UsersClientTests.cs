using System.Net;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Sniper.Tests.Integration.Helpers;
using Xunit;

namespace Sniper.Tests.Integration.Clients
{
    public class UsersClientTests
    {
        public class TheGetMethod
        {
            [IntegrationTest]
            public async Task ReturnsSpecifiedUser()
            {
                var github = Helper.GetAuthenticatedClient();

                var user = await github.User.Get("tclem");

                Assert.Equal("GitHub", user.Company);
                Assert.Equal(AccountType.User, user.Type);
            }

            [IntegrationTest]
            public async Task ReturnsSpecifiedOrganization()
            {
                var github = Helper.GetAuthenticatedClient();

                var user = await github.User.Get("Sniper");

                Assert.Null(user.Company);
                Assert.Equal(AccountType.Organization, user.Type);
            }

            [IntegrationTest]
            public async Task ReturnsSpecifiedUserUsingAwaitableCredentialProvider()
            {
                var github = new GitHubClient(new ProductHeaderValue("SniperTests"),
                    new ObservableCredentialProvider());

                var user = await github.User.Get("tclem");

                Assert.Equal("GitHub", user.Company);
            }

            private class ObservableCredentialProvider : ICredentialStore
            {
                public async Task<Credentials> GetCredentials()
                {
                    return await Observable.Return(Helper.Credentials);
                }
            }
        }

        public class TheCurrentMethod
        {
            [IntegrationTest]
            public async Task ReturnsSpecifiedUser()
            {
                var github = Helper.GetAuthenticatedClient();

                var user = await github.User.Current();

                Assert.Equal(Helper.UserName, user.Login);
                Assert.Equal(AccountType.User, user.Type);
            }
        }

        public class TheUpdateMethod
        {
            [IntegrationTest]
            public async Task FailsWhenNotAuthenticated()
            {
                var github = Helper.GetAnonymousClient();

                var userUpdate = new UserUpdate
                {
                    Name = Helper.Credentials.Login,
                    Bio = "UPDATED BIO"
                };

                var e = await Assert.ThrowsAsync<AuthorizationException>(() => github.User.Update(userUpdate));
                Assert.Equal(HttpStatusCode.Unauthorized, e.StatusCode);
            }

            [IntegrationTest]
            public async Task FailsWhenAuthenticatedWithBadCredentials()
            {
                var github = Helper.GetBadCredentialsClient();

                var userUpdate = new UserUpdate
                {
                    Name = Helper.Credentials.Login,
                    Bio = "UPDATED BIO"
                };

                var e = await Assert.ThrowsAsync<AuthorizationException>(() => github.User.Update(userUpdate));
                Assert.Equal(HttpStatusCode.Unauthorized, e.StatusCode);
            }
        }
    }
}
