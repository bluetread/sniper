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
    /// See the <a href="https://md5.tpondemand.com/api/v1/RequestSimpleHistories/meta">API documentation - RequestSimpleHistory</a>
    /// </remarks>
    [CannotCreateReadUpdateDelete]
    public class RequestSimpleHistory : SimpleHistoryExtendedBase, IHasRequest
    {
        [JsonProperty(Required = Required.Default)]
        public Request Request { get; internal set; }
    }
}