using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Any User that is a part of a Project Team.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/ProjectMembers/meta">API documentation - ProjectMember</a>
    /// </remarks>
    public class ProjectMember : Entity, IHasActive, IHasProject, IHasUser, IHasRole
    {
        public int Allocation { get; set; }
        public bool IsActive { get; set; }
        public DateTime MembershipEndDate { get; set; }
        public DateTime MembershipStartDate { get; set; }
        public decimal WeeklyAvailableHours { get; set; }

        #region Required for Create


        [RequiredForCreate(JsonProperties.Id)]
        public Project Project { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public Role Role { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public User User { get; set; }

        #endregion
        public Collection<UserProjectAllocation> Allocations { get; set; }
    }
}