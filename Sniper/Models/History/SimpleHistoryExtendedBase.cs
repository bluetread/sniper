using Sniper.Common;
using Sniper.Contracts.Entities.Common;

namespace Sniper.History
{
    public class SimpleHistoryExtendedBase : SimpleHistoryBase, IHasEffort, IHasIteration, IHasRelease
    {
        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }

        public Iteration Iteration { get; set; }
        public Release Release { get; set; }
    }
}