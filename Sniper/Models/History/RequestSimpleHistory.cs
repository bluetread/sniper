using Sniper.Common;
using Sniper.Contracts;

namespace Sniper.History
{
    ///<summary>
    /// A change of an entity
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RequestSimpleHistories/meta">API documentation - RequestSimpleHistory</a>
    /// </remarks>
    public class RequestSimpleHistory : SimpleHistoryExtendedBase, IHasRequest

    {
        public Request Request { get; set; }
    }
}
