using Sniper.Contracts;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Set of states
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Workflows/meta">API documentation - Workflow</a>
    /// </remarks>
    public class Workflow : IHasId, IHasName, IHasEntityType, IHasProcess, IHasEntityStates, IHasTeamProjects
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EntityType EntityType { get; set; }
        public Process Process { get; set; }
        public Workflow ParentWorkflow { get; set; }

        public Collection<EntityState> EntityStates { get; set; }
        public Collection<Workflow> SubWorkflows { get; set; }
        public Collection<TeamProject> TeamProjects { get; set; }
    }
}
