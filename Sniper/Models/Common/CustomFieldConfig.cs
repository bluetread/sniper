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
        public string CalculationModel { get; set; }
        public bool CalculationModelContainsCollections { get; set; }
        public string DefaultValue { get; set; }
        public string Units { get; set; }
    }
}