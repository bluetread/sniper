using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;

namespace Sniper.Common
{
    ///<summary>
    /// Effort for Assignable by Role and User.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/AssignedEfforts/meta">API documentation - AssignedEffort</a>
    /// </remarks>
    public class AssignedEffort : Entity, IHasEffort, IHasInitialEstimate, IHasRoleTimes,
        IHasAssignable, IHasRole, IHasGeneralUser
    {
        [JsonProperty(Required = Required.Default)]
        public decimal Effort { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortCompleted { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortToDo { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal InitialEstimate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal RoleTimeRemain { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal RoleTimeSpent { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Assignable Assignable { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Role Role { get; set; }

        [JsonProperty(Required = Required.Default)]
        public User GeneralUser { get; set; }
    }
}