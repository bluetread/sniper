using Newtonsoft.Json;
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
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public int Allocation { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Project Project { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Role Role { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public User User { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public bool IsActive { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime MembershipEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime MembershipStartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal WeeklyAvailableHours { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserProjectAllocation> Allocations { get; set; }
    }
}