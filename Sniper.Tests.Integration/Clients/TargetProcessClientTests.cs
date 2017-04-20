using System.Threading.Tasks;
using Sniper.Tests.Integration.Helpers;
using Xunit;

namespace Sniper.Tests.Integration.Clients
{
    public class TargetProcessClientTests
    {
   
        [IntegrationTest]
        public async Task CanRetrieveLastApiInfoWithEtag()
        {
            // To check for etag, I'm using a new repository
            // As per suggestion here -> https://github.com/Sniper/Sniper.net/pull/855#issuecomment-126966532
            var github = Helper.GetAuthenticatedClient();
            var repoName = Helper.MakeNameWithTimestamp("public-repo");

            using (var context = await github.CreateRepositoryContext(new NewRepository(repoName)))
            {
                var createdRepository = context.Repository;

                var result = github.GetLastApiInfo();

                Assert.True(result.Links.Count == 0);
                Assert.True(result.AcceptedOauthScopes.Count > -1);
                Assert.True(result.OauthScopes.Count > -1);
                Assert.False(string.IsNullOrEmpty(result.Etag));
                Assert.True(result.RateLimit.Limit > 0);
                Assert.True(result.RateLimit.Remaining > -1);
                Assert.NotNull(result.RateLimit.Reset);
            }
        }

      
    }
}
}
