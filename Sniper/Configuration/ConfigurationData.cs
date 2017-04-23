using System;
using System.IO;
using Newtonsoft.Json;
using Sniper.FileAndDirectory;
using Sniper.Http;

namespace Sniper.Configuration
{
    public sealed class ConfigurationData 
    {
        private static readonly Lazy<ConfigurationData> _configurationData = new Lazy<ConfigurationData>(() => new ConfigurationData());
        public static ConfigurationData Instance => _configurationData.Value;
        private IConfigurationData ConfigurationInfo { get; }
        public ICredentials Credentials => ConfigurationInfo.Credentials;
        public ISiteInfo SiteInfo => ConfigurationInfo.SiteInfo;

        private ConfigurationData()
        {
            ConfigurationInfo = JsonConvert.DeserializeObject<ConfigurationValues>(File.ReadAllText(ConfigurationFilePath));
        }

        public static string ConfigurationFilePath => Path.Combine(FileSystemHelpers.RootSolutionPath,
            ConfigurationFiles.ConfigurationDirectory, ConfigurationFiles.ApplicationConfigurationFile);
    }

   

    
}