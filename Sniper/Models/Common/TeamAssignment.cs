using Newtonsoft.Json;
using Sniper.Application;
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
    [CanCreateReadUpdateDelete]
    public class TeamAssignment : Entity, IHasDateRange, IHasAssignable, IHasEntityState, IHasTeam
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.Name, 
            JsonProperties.EntityState, JsonProperties.Project, JsonProperties.Priority)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Assignable Assignable { get; internal set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Team Team { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime? EndDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? StartDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public EntityState EntityState { get; set; }
    }
}