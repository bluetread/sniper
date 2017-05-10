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
    /// See the <a href="https://md5.tpondemand.com/api/v1/ImpedimentSimpleHistories/meta">API documentation - ImpedimentSimpleHistory</a>
    /// </remarks>
    [CannotCreateReadUpdateDelete]
    public class ImpedimentSimpleHistory : SimpleHistoryBase, IHasImpediment
    {
        [JsonProperty(Required = Required.Default)]
        public Impediment Impediment { get; internal set; }
    }
}