using Sniper.Contracts;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// State of Entity. Collection of EntityStates form Workflow for Entity. For example, Bug has four EntityStates by default: Open, Fixed, Invalid and Done.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/EntityStates/meta">API documentation - EntityState</a>
    /// </remarks>
    public class EntityState : IHasId, IHasName, IHasRole, IHasProjects, IHasAssignables
    {
        public int Id { get; set; }
        public bool IsCommentRequired { get; set; }
        public bool IsFinal { get; set; }
        public bool IsInitial { get; set; }
        public bool IsPlanned { get; set; }
        public string Name { get; set; }
        public double NumericPriority { get; set; }

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
