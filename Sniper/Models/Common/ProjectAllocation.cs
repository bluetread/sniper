using Sniper.Contracts.Entities.Common;
using System;

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
        public DateTime? EffectiveEndDate { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsEffective { get; set; }
        public int Percentage { get; set; }
        public DateTime? StartDate { get; set; }

        public EntityType EntityType { get; set; }
        public Project Project { get; set; }
    }
}