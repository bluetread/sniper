using System.Threading.Tasks;
using Sniper.Tests.Integration.Helpers;
using Xunit;

namespace Sniper.Tests.Integration.Clients
{
    public class RepositoryPagesClientTests
    {
        public class TheGetMethod
        {
            private readonly IRepositoryPagesClient _repositoryPagesClient;
            private const string owner = "Sniper";
            private const string name = "Sniper.net";
            private const long repositoryId = 7528679;

            public TheGetMethod()
            {
                var github = Helper.GetAuthenticatedClient();
                _repositoryPagesClient = github.Repository.Page;
            }

            [IntegrationTest(Skip = "These tests require repository admin rights - see https://github.com/Sniper/Sniper.net/issues/1263 for discussion")]
            public async Task ReturnsMetadata()
            {
                var data = await _repositoryPagesClient.Get(owner, name);
                Assert.Equal("https://api.github.com/repos/Sniper/Sniper.net/pages", data.Url);
            }

            [IntegrationTest(Skip = "These tests require repository admin rights - see https://github.com/Sniper/Sniper.net/issues/1263 for discussion")]
            public async Task ReturnsMetadataWithRepositoryId()
            {
                var data = await _repositoryPagesClient.Get(repositoryId);
                Assert.Equal("https://api.github.com/repos/Sniper/Sniper.net/pages", data.Url);
            }
        }
    }
}