using Newtonsoft.Json;
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

        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal WeeklyAvailableHours { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string ActiveDirectoryName { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime AvailableFrom { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int AvailableFutureAllocation { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal AvailableFutureHours { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal CurrentAvailableHours { get; set; }

        [JsonProperty(Required = Required.Default)]
        public override string FirstName { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsContributor { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsObserver { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? LastLoginDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public override string LastName { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Locale { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Skills { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Role Role { get; set; }

        #region Collections

        [JsonProperty(Required = Required.Default)]
        public Collection<Process> AdminProcesses { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<CustomActivity> CustomActivities { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<GeneralFollower> Following { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Impediment> Impediments { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Milestone> Milestones { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<ProjectMember> ProjectMembers { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Revision> Revisions { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamMember> TeamMember { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Time> Times { get; internal set; }

        #endregion
    }
}