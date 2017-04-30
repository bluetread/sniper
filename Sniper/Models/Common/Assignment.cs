using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// An assignment of the User Story, Task, Bug, etc. with a specific Role and user.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Assignments/meta">API documentation - Assignment</a>
    /// </remarks>
    public class Assignment : IHasId, IHasAssignable, IHasRole
    {
        public int Id { get; set; }

        public Assignable Assignable { get; set; }
        public Role Role { get; set; }
        public User GeneralUser { get; set; }
    }
}