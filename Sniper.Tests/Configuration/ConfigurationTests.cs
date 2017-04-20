using System.IO;
using Sniper.Configuration;
using Sniper.FileAndDirectory;
using Xunit;

namespace Sniper.Tests.Configuration
{
    public class ConfigurationTests
    {
        [Fact]
        public void FindsConfigurationFile()
        {
            var configFile = ConfigurationData.ConfigurationFilePath;
            Assert.NotNull(configFile);
            Assert.EndsWith(ConfigurationFiles.ApplicationConfigurationFile, configFile);
            Assert.True(File.Exists(configFile));
        }

        [Fact]
        public void ConfigurationFileHasValues()
        {
            var configData = ConfigurationData.Instance;
            Assert.NotNull(configData);
            Assert.NotNull(configData.SiteInfo);
            Assert.NotNull(configData.SiteInfo.BaseUrl);
        }


        [Fact]
        public void ConfigurationFileHasAllValues()
        {
            var configData = ConfigurationData.Instance;
            Assert.NotNull(configData);
            Assert.NotNull(configData.SiteInfo);
            Assert.NotEmpty(configData.SiteInfo.BaseUrl);
            Assert.NotEmpty(configData.SiteInfo.HostName);
            Assert.NotEmpty(configData.SiteInfo.SiteUrl);
            Assert.NotEmpty(configData.SiteInfo.UserName);
            Assert.True(configData.SiteInfo.Version > 0);
        }
    }
}
