using Sniper.Common;
using Sniper.Contracts;

namespace Sniper.History
{
    ///<summary>
    /// A change of an entity
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/FeatureSimpleHistories/meta">API documentation - FeatureSimpleHistory</a>
    /// </remarks>
    public class FeatureSimpleHistory : SimpleHistoryExtendedBase, IHasFeature
    {
        public Feature Feature { get; set; }
    }
}
