using Newtonsoft.Json;
using Sniper.Common;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.History
{
    ///<summary>
    /// A change of an entity
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/FeatureSimpleHistories/meta">API documentation - FeatureSimpleHistory</a>
    /// </remarks>
    [CannotCreateReadUpdateDelete]
    public class FeatureSimpleHistory : SimpleHistoryExtendedBase, IHasFeature
    {
        [JsonProperty(Required = Required.Default)]
        public Feature Feature { get; internal set; }
    }
}