using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Base entity for Epic, Feature, User Story, Task, Bug, Test Plan, Test Plan Run, Request. It can be assigned to people and has workflow.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Assignables/meta">API documentation - Assignable</a>
    /// </remarks>
    public class Assignable : General, IHasEffort, IHasAssignedEfforts, IHasAssignedTeams, IHasForecastEndDate,
        IHasLeadCycleTimes, IHasPlannedDates, IHasProgress, IHasTimeSpent, IHasEntityState, IHasImpediments,
        IHasIteration, IHasPriority, IHasRelease, IHasResponsibleTeam, IHasTimes, IHasUnits
    {
        public double CycleTime { get; set; }
        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public DateTime? ForecastEndDate { get; set; }
        public DateTime? LastStateChangeDate { get; set; }
        public double LeadTime { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public decimal Progress { get; set; }
        public decimal TimeRemain { get; set; }
        public decimal TimeSpent { get; set; }
        public string Units { get; set; }

        public EntityState EntityState { get; set; }
        public Iteration Iteration { get; set; }
        public Priority Priority { get; set; }
        public Release Release { get; set; }
        public TeamAssignment ResponsibleTeam { get; set; }
        public TeamIteration TeamIteration { get; set; }

        public Collection<AssignedEffort> AssignedEfforts { get; set; }
        public Collection<TeamAssignment> AssignedTeams { get; set; }
        public Collection<GeneralUser> AssignedUser { get; set; }
        public Collection<Assignment> Assignments { get; set; }
        public Collection<Impediment> Impediments { get; set; }
        public Collection<Revision> Revisions { get; set; }
        public Collection<RoleEffort> RoleEfforts { get; set; }
        public Collection<Time> Times { get; set; }
    }
}