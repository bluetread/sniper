using Sniper.Common;
using Sniper.Contracts;

namespace Sniper.History
{
    ///<summary>
    /// A change of an entity
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/ImpedimentSimpleHistories/meta">API documentation - ImpedimentSimpleHistory</a>
    /// </remarks>
    public class ImpedimentSimpleHistory : SimpleHistoryBase, IHasImpediment
    {
        public Impediment Impediment { get; set; }
    }
}
