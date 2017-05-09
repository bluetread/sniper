using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Common;
using Sniper.Contracts.Entities.Common;
using Sniper.Contracts.Entities.History;
using System;

namespace Sniper.History
{
    public abstract class SimpleHistoryBase : Entity, IHasDate, IHasEntityState, IHasModifier, IHasProject
    {
        [JsonProperty(JsonProperties.Date, Required = Required.Default)]
        public DateTime? EntryDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public EntityState EntityState { get; set; }

        [JsonProperty(Required = Required.Default)]
        public GeneralUser Modifier { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Project Project { get; set; }
    }
}