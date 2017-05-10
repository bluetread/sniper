using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using Sniper.Contracts.Entities.History;
using Sniper.History;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Anything that prevents a team member from working as efficiently as possible. Impediment can relate to Task, User Story, Bug or Feature.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Impediments/meta">API documentation - Impediment</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Impediment : General, IHasPrivate, IHasPlannedDates,
        IHasAssignable, IHasEntityState, IHasImpedimentHistory, IHasPriority, IHasResponsibleUser
    {

        #region Required for Create

        [RequiredForCreate]

        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        #endregion


        [JsonProperty(Required = Required.Default)]
        public bool IsPrivate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? PlannedEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? PlannedStartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Assignable Assignable { get; set; }

        [JsonProperty(Required = Required.Default)]
        public EntityState EntityState { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<ImpedimentSimpleHistory> History { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Priority Priority { get; set; }

        [JsonProperty(Required = Required.Default)]
        public User Responsible { get; set; }
    }
}