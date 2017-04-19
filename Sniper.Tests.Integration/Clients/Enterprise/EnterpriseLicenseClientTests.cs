using System.Threading.Tasks;
using Xunit;

namespace Sniper.Tests.Integration.Clients.Enterprise
{
    public class EnterpriseLicenseClientTests
    {
        private readonly IGitHubClient _github;

        public EnterpriseLicenseClientTests()
        {
            _github = EnterpriseHelper.GetAuthenticatedClient();
        }

        [GitHubEnterpriseTest]
        public async Task CanGetLicense()
        {
            var licenseInfo = await
                _github.Enterprise.License.Get();

            Assert.NotNull(licenseInfo);
        }
    }
}