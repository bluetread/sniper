using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using Sniper.Application;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Any Project in which team participates.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TeamProjects/meta">API documentation - TeamProject</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class TeamProject : Entity, IHasDateRange, IHasTeam, IHasProject, IHasAllocations, IHasWorkFlows
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Project Project { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Team Team { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime? EndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsProjectAccessed { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? StartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<ProjectAllocation> Allocations { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Workflow> Workflows { get; internal set; }
    }
}