using Sniper.Contracts.Entities.Common;
using System;

namespace Sniper.Common
{
    ///<summary>
    /// Any User that is a part of a Team.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TeamMembers/meta">API documentation - TeamMember</a>
    /// </remarks>
    public class TeamMember : Entity, IHasDateRange, IHasRole, IHasTeam, IHasUser
    {
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }

        public Role Role { get; set; }
        public User User { get; set; }
        public Team Team { get; set; }
    }
}