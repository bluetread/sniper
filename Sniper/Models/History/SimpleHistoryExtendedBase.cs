using Newtonsoft.Json;
using Sniper.Common;
using Sniper.Contracts.Entities.Common;

namespace Sniper.History
{
    public class SimpleHistoryExtendedBase : SimpleHistoryBase, IHasEffort, IHasIteration, IHasRelease
    {
        [JsonProperty(Required = Required.Default)]
        public decimal Effort { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortCompleted { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortToDo { get; set; }
        
        [JsonProperty(Required = Required.Default)]
        public Iteration Iteration { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Release Release { get; set; }
    }
}