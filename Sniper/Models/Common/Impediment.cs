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
    public class Impediment : General, IHasPrivate, IHasPlannedDates,
        IHasAssignable, IHasEntityState, IHasImpedimentHistory, IHasPriority, IHasResponsibleUser
    {

        #region Required for Create

        [RequiredForCreate]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public override Project Project { get; set; }

        #endregion

        public bool IsPrivate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public Assignable Assignable { get; set; }
        public EntityState EntityState { get; set; }
        public Collection<ImpedimentSimpleHistory> History { get; set; }
        public Priority Priority { get; set; }
        public User Responsible { get; set; }
    }
}