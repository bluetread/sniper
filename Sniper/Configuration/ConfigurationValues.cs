using Newtonsoft.Json;
using Sniper.Http;

namespace Sniper.Configuration
{
    public class ConfigurationValues : IConfigurationData
    {
        [JsonConverter(typeof(JsonHelpers.ConcreteConverter<Credentials>))]
        public ICredentials Credentials { get; set; }

        [JsonConverter(typeof(JsonHelpers.ConcreteConverter<SiteInfo>))]
        public ISiteInfo SiteInfo { get; set; }
    }
}