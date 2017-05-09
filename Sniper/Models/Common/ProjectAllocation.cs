using Sniper.Contracts.Entities.Common;
using System;
using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Base allocation to a Project
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/ProjectAllocations/meta">API documentation - ProjectAllocation</a>
    /// </remarks>
    public class ProjectAllocation : Entity, IHasDateRange, IHasEntityType, IHasProject, IHasEffectiveDates
    {
        #region Required For Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public int Percentage { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public Project Project { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime? EffectiveEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? EffectiveStartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? EndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsEffective { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? StartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public EntityType EntityType { get; set; }

    }
}