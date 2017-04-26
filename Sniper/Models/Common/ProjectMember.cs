using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Any User that is a part of a Project Team.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/ProjectMembers/meta">API documentation - ProjectMember</a>
    /// </remarks>
    public class ProjectMember : IHasId, IHasActive, IHasProject, IHasUser, IHasRole
    {
        public int Id { get; set; }
        public int Allocation { get; set; }
        public bool IsActive { get; set; }
        public DateTime MembershipEndDate { get; set; }
        public DateTime MembershipStartDate { get; set; }
        public decimal WeeklyAvailableHours { get; set; }

        public Project Project { get; set; }
        public Role Role { get; set; }
        public User User { get; set; }

        public Collection<UserProjectAllocation> Allocations { get; set; }
    }
}

