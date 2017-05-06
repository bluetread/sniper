using Sniper.Contracts.Entities.Common;

namespace Sniper.Common
{
    ///<summary>
    /// Effort for Assignable by Role. For example, User Story can have 5 hours of Developer effort
    /// + 3 hours of Tester effort. The total effort will be 8 hours.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RoleEfforts/meta">API documentation - RoleEffort</a>
    /// </remarks>
    public class RoleEffort : Entity, IHasEffort, IHasInitialEstimate, IHasTimeSpent, IHasAssignable, IHasRole
    {
        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public decimal InitialEstimate { get; set; }
        public decimal TimeRemain { get; set; }
        public decimal TimeSpent { get; set; }

        public Assignable Assignable { get; set; }
        public Role Role { get; set; }
    }
}