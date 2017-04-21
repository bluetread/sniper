using System;
using System.IO;
using Newtonsoft.Json;
using Sniper.FileAndDirectory;

// ReSharper disable once CheckNamespace
namespace Sniper.Configuration
{
    public sealed class ConfigurationData 
    {
        private static readonly Lazy<ConfigurationData> _configurationData = new Lazy<ConfigurationData>(() => new ConfigurationData());
        public static ConfigurationData Instance => _configurationData.Value;
        private IConfigurationData Data { get; }
        public SiteData SiteInfo => Data.SiteInfo;

        private ConfigurationData()
        {
            Data = JsonConvert.DeserializeObject<IConfigurationData>(File.ReadAllText(ConfigurationFilePath));
        }

        public static string ConfigurationFilePath => Path.Combine(FileSystemHelpers.RootSolutionPath,
            ConfigurationFiles.ConfigurationDirectory, ConfigurationFiles.ApplicationConfigurationFile);
    }

   

    
}