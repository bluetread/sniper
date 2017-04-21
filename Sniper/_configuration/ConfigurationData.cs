using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using Sniper.FileAndDirectory;
using Sniper.Http;

// ReSharper disable once CheckNamespace
namespace Sniper.Configuration
{
    public sealed class ConfigurationData
    {
        private static readonly Lazy<ConfigurationData> _configurationData = new Lazy<ConfigurationData>(() => new ConfigurationData());
        public static ConfigurationData Instance => _configurationData.Value;
        private ConfigData Data { get; }
        public SiteData SiteInfo => Data.SiteInfo;

        private ConfigurationData()
        {
            Data = JsonConvert.DeserializeObject<ConfigData>(File.ReadAllText(ConfigurationFilePath));
        }

        public static string ConfigurationFilePath => Path.Combine(FileSystemHelpers.RootSolutionPath,
            ConfigurationFiles.ConfigurationDirectory, ConfigurationFiles.ApplicationConfigurationFile);
    }

    public sealed class ConfigData
    {
        public SiteData SiteInfo { get; set; }
    }

    public sealed class SiteData
    {
        public string BaseUrl { get; set; }
        public string HostName { get; set; }
        public bool IsApiIncluded { get; set; } //include "/api" in route
        public bool IsVersionIncluded { get; set; } //include version number "/1"
        public bool IsVersionLetterIncluded { get; set; } //include "v", as in "/v1" or "/v2" instead of "/1"
        public string Password { get; set; }
        public string UserName { get; set; }
        public int Version { get; set; }

        public string SiteUrl => $@"{Protocols.HypertextSecure}://{HostName}.{BaseUrl}{(IsApiIncluded ? 
            "/api" : string.Empty)}/{(IsVersionLetterIncluded ? "v" : string.Empty)}{(IsVersionIncluded ? Version.ToString(CultureInfo.CurrentCulture) : string.Empty)}/";
    }
}