using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

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

        #region Required for Create

        [RequiredForCreate]
        public override string Email { get; set; }
        [RequiredForCreate]
        public override string FirstName { get; set; }
        [RequiredForCreate]
        public override string LastName { get; set; }
        [RequiredForCreate]
        public override string Login { get; set; }
        [RequiredForCreate]
        public override string Password { get; set; }

        #endregion

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