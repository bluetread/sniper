using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Represents an user. User has Role and can be added to project teams.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Users/meta">API documentation - User</a>
    /// </remarks>
    public class User : GeneralUser, IHasRole, IHasTimes, IHasImpediments, IHasCustomActivities,
        IHasRevisions, IHasTeamMembers, IHasProjectMembers, IHasMilestones
    {
        public string ActiveDirectoryName { get; set; }
        public DateTime AvailableFrom { get; set; }
        public int AvailableFutureAllocation { get; set; }
        public int AvailableFutureHours { get; set; }
        public decimal CurrentAvailableHours { get; set; }
        public bool IsContributor { get; set; }
        public bool IsObserver { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string Locale { get; set; }
        public string Skills { get; set; }
        public decimal WeeklyAvailableHours { get; set; }

        public Role Role { get; set; }

        public Collection<Process> AdminProcesses { get; set; }
        public Collection<CustomActivity> CustomActivities { get; set; }
        public Collection<GeneralFollower> Following { get; set; }
        public Collection<Impediment> Impediments { get; set; }
        public Collection<Milestone> Milestones { get; set; }
        public Collection<ProjectMember> ProjectMembers { get; set; }
        public Collection<Revision> Revisions { get; set; }
        public Collection<TeamMember> TeamMember { get; set; }
        public Collection<Time> Times { get; set; }
        
    }
}
