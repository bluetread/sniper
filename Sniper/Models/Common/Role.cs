using Sniper.Contracts;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Defines permissions for User.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Roles/meta">API documentation - Role</a>
    /// </remarks>
    public class Role : IHasId, IHasName, IHasEntityStates, IHasRoleEfforts
    {
        public int Id { get; set; }
        public bool CanChangeOwner { get; set; }
        public bool HasEffort { get; set; }
        public string Name { get; set; }

        public Collection<EntityState> EntityStates { get; set; }
        public Collection<RoleEffort> RoleEfforts { get; set; }
    }
}
