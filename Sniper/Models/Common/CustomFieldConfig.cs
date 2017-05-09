using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;

namespace Sniper.Common
{
    ///<summary>
    /// Custom field configuration.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/CustomFieldConfigs/meta">API documentation - CustomFieldConfig</a>
    /// </remarks>
    public class CustomFieldConfig : Entity, IHasUnits
    {
        [JsonProperty(Required = Required.Default)]
        public string CalculationModel { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool CalculationModelContainsCollections { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string DefaultValue { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Units { get; set; }
    }
}