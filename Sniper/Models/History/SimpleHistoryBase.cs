using System;
using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Common;
using Sniper.Contracts;
using Sniper.Contracts.History;

namespace Sniper.History
{
    public abstract class SimpleHistoryBase : IHasId, IHasDate, IHasEntityState, IHasModifier, IHasProject
    {
        public int Id { get; set; }
        [JsonProperty(JsonProperties.Date)]
        public DateTime? EntryDate { get; set; }

        public EntityState EntityState { get; set; }
        public GeneralUser Modifier { get; set; }
        public Project Project { get; set; }
    }
}
