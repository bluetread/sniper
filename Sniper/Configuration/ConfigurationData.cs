using Newtonsoft.Json;
using Sniper.FileAndDirectory;
using Sniper.Http;
using System;
using System.IO;
using static Sniper.WarningsErrors.MessageSuppression;
using ICredentials = Sniper.Http.ICredentials;

namespace Sniper.Configuration
{
    public sealed class ConfigurationData : IConfigurationData
    {
        private static readonly Lazy<ConfigurationData> _configurationData = new Lazy<ConfigurationData>(() => new ConfigurationData());
        public static ConfigurationData Instance => _configurationData.Value;
        //private IConfigurationData ConfigurationInfo { get; }
        public ICredentials Credentials { get; }
        public ISiteInfo SiteInfo { get; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(Categories.Design, MessageAttributes.DoNotCatchGeneralExceptionTypes)]
        private ConfigurationData()
        {
            try
            {
                var data = JsonConvert.DeserializeObject<ConfigurationValues>(File.ReadAllText(ConfigurationFilePath));
                Credentials = data.Credentials ?? DefaultCredentials;
                SiteInfo = data.SiteInfo ?? DefaultSiteInfo;
            }
            catch (Exception)
            {
                Credentials = DefaultCredentials;
                SiteInfo = DefaultSiteInfo;
            }
        }

        public static ICredentials DefaultCredentials => new Credentials(AuthenticationType.Anonymous);
        public static ISiteInfo DefaultSiteInfo => new SiteInfo();

        public static string ConfigurationFilePath => Path.Combine(FileSystemHelpers.RootSolutionPath,
            ConfigurationFiles.ConfigurationDirectory, ConfigurationFiles.ApplicationConfigurationFile);
    }

   

    
}