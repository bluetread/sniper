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
        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public decimal InitialEstimate { get; set; }
        public decimal RoleTimeRemain { get; set; }
        public decimal RoleTimeSpent { get; set; }

        public Assignable Assignable { get; set; }
        public Role Role { get; set; }
        public User GeneralUser { get; set; }
    }
}