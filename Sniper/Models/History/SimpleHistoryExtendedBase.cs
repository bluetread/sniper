using Newtonsoft.Json;
using Sniper.Common;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.History
{
    [CannotCreateReadUpdateDelete]
    public abstract class SimpleHistoryExtendedBase : SimpleHistoryBase, IHasEffort, IHasIteration, IHasRelease
    {
        [JsonProperty(Required = Required.Default)]
        public decimal Effort { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortCompleted { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortToDo { get; internal set; }
        
        [JsonProperty(Required = Required.Default)]
        public Iteration Iteration { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Release Release { get; internal set; }
    }
}