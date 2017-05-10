using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Effort for Assignable by Role. For example, User Story can have 5 hours of Developer effort
    /// + 3 hours of Tester effort. The total effort will be 8 hours.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RoleEfforts/meta">API documentation - RoleEffort</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class RoleEffort : Entity, IHasEffort, IHasInitialEstimate, IHasTimeSpent, IHasAssignable, IHasRole
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.Name, JsonProperties.Project, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Assignable Assignable { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Role Role { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public decimal Effort { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortCompleted { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortToDo { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal InitialEstimate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal TimeRemain { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal TimeSpent { get; set; }
    }
}