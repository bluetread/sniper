using Sniper.Configuration;
using Sniper.FileAndDirectory;
using System.IO;
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
            Assert.NotEmpty(configData.SiteInfo.ApiUrl);
            Assert.NotEmpty(configData.SiteInfo.BaseUrl);
            Assert.NotEmpty(configData.SiteInfo.HostName);
            Assert.NotNull(configData.SiteInfo.IsApiIncluded);
            Assert.NotNull(configData.SiteInfo.IsVersionIncluded);
            Assert.NotNull(configData.SiteInfo.IsVersionLetterIncluded);
            Assert.True(configData.SiteInfo.Version > 0);

            Assert.NotEmpty(configData.Credentials.Login);
            Assert.NotEmpty(configData.Credentials.Password);
            Assert.NotNull(configData.Credentials.AuthenticationType);
        }
    }
}