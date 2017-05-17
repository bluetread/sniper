using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Any User that is a part of a Team.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TeamMembers/meta">API documentation - TeamMember</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class TeamMember : Entity, IHasDateRange, IHasRole, IHasTeam, IHasUser
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Role Role { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Team Team { get; set; }

        [RequiredForCreate(JsonProperties.Email, JsonProperties.Login, 
            JsonProperties.Password, JsonProperties.WeeklyAvailableHours)]
        [JsonProperty(Required = Required.DisallowNull)]
        public User User { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime? EndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? StartDate { get; set; }
    }
}