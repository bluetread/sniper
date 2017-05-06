using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// State of Entity. Collection of EntityStates form Workflow for Entity. For example, Bug has four EntityStates by default: Open, Fixed, Invalid and Done.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/EntityStates/meta">API documentation - EntityState</a>
    /// </remarks>
    public class EntityState : Entity, IHasName, IHasRole, IHasProjects, IHasAssignables
    {
        public bool IsCommentRequired { get; set; }
        public bool IsFinal { get; set; }
        public bool IsInitial { get; set; }
        public bool IsPlanned { get; set; }
        public double NumericPriority { get; set; }

        #region Required for Create

        [RequiredForCreate]
        public string Name { get; set; }

        #endregion

        public EntityState ParentEntityState { get; set; }
        public Role Role { get; set; }
        public Workflow Workflow { get; set; }

        public Collection<Assignable> Assignables { get; set; }
        public Collection<EntityState> NextStates { get; set; }
        public Collection<EntityState> PreviousStates { get; set; }
        public Collection<Project> Projects { get; set; }
        public Collection<EntityState> SubEntityStates { get; set; }
    }
}