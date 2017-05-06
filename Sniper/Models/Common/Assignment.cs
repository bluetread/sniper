using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// An assignment of the User Story, Task, Bug, etc. with a specific Role and user.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Assignments/meta">API documentation - Assignment</a>
    /// </remarks>
    public class Assignment : Entity, IHasAssignable, IHasRole
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.Id)]
        public Assignable Assignable { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public Role Role { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public User GeneralUser { get; set; }

        #endregion

    }
}