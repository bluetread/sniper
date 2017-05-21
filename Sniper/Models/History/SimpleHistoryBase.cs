using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Common;
using Sniper.Contracts.Entities.Common;
using Sniper.Contracts.Entities.History;
using System;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.History
{
    [CannotCreateReadUpdateDelete]
    public abstract class SimpleHistoryBase : Entity, IHasDate, IHasEntityState, IHasModifier, IHasProject
    {
        [JsonProperty(JsonProperties.Date, Required = Required.Default)]
        public DateTime? EntryDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public EntityState EntityState { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public GeneralUser Modifier { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Project Project { get; internal set; }
    }
}