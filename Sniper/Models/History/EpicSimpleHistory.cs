using Newtonsoft.Json;
using Sniper.Common;
using Sniper.Contracts.Entities.Common;

namespace Sniper.History
{
    ///<summary>
    /// A change of an entity
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/EpicSimpleHistories/meta">API documentation - EpicSimpleHistory</a>
    /// </remarks>
    public class EpicSimpleHistory : SimpleHistoryExtendedBase, IHasEpic
    {
        [JsonProperty(Required = Required.Default)]
        public Epic Epic { get; set; }
    }
}