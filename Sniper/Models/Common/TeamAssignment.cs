using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Assignment of the Team with a specific State on Assignable. Known as TeamState.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TeamAssignments/meta">API documentation - TeamAssignment</a>
    /// </remarks>
    public class TeamAssignment : Entity, IHasDateRange, IHasAssignable, IHasEntityState, IHasTeam
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public Assignable Assignable { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public Team Team { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime? EndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? StartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public EntityState EntityState { get; set; }
    }
}