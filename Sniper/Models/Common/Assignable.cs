using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Base entity for Epic, Feature, User Story, Task, Bug, Test Plan, Test Plan Run, Request. It can be assigned to people and has workflow.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Assignables/meta">API documentation - Assignable</a>
    /// </remarks>
    [CanCreateReadUpdateDelete(CanCreate = false)]
    public class Assignable : General, IHasEffort, IHasAssignedEfforts, IHasAssignedTeams, IHasForecastEndDate,
        IHasLeadCycleTimes, IHasPlannedDates, IHasProgress, IHasTimeSpent, IHasEntityState, IHasImpediments,
        IHasIteration, IHasPriority, IHasRelease, IHasResponsibleTeam, IHasTimes, IHasUnits
    {
        [JsonProperty(Required = Required.Default)]
        public virtual double CycleTime { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual decimal Effort { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual decimal EffortCompleted { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual decimal EffortToDo { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? ForecastEndDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? LastStateChangeDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual double LeadTime { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? PlannedEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? PlannedStartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual decimal Progress { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual decimal TimeRemain { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual decimal TimeSpent { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual string Units { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual EntityState EntityState { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Iteration Iteration { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Priority Priority { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Release Release { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual TeamAssignment ResponsibleTeam { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual TeamIteration TeamIteration { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<AssignedEffort> AssignedEfforts { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<TeamAssignment> AssignedTeams { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<GeneralUser> AssignedUser { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Assignment> Assignments { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Impediment> Impediments { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Revision> Revisions { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<RoleEffort> RoleEfforts { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Time> Times { get; internal set; }
    }
}