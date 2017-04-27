using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Any Project in which team participates.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TeamProjects/meta">API documentation - TeamProject</a>
    /// </remarks>
    public class TeamProject : IHasId, IHasDateRange, IHasTeam, IHasProject, IHasAllocations, IHasWorkFlows
    {
        public int Id { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsProjectAccessed { get; set; }
        public DateTime? StartDate { get; set; }

        public Project Project { get; set; }
        public Team Team { get; set; }

        public Collection<ProjectAllocation> Allocations { get; set; }
        public Collection<Workflow> Workflows { get; set; }
    }
}