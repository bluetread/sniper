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
        [JsonProperty(JsonProperties.Date)]
        public DateTime? EntryDate { get; set; }

        public EntityState EntityState { get; set; }
        public GeneralUser Modifier { get; set; }
        public Project Project { get; set; }
    }
}