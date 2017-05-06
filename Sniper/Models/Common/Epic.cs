using Sniper.Contracts.Entities.Common;
using Sniper.Contracts.Entities.History;
using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// A high-level scope of work which contains Features.
    /// Can be assigned to Release. Can't be assigned to Iteration.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Epics/meta">API documentation - Epic</a>
    /// </remarks>
    public class Epic : Assignable, IHasInitialEstimate, IHasFeatures, IHasEpicHistory
    {
        public decimal InitialEstimate { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<EpicSimpleHistory> History { get; set; }
    }
}