using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Defines permissions for User.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Roles/meta">API documentation - Role</a>
    /// </remarks>
    public class Role : Entity, IHasName, IHasEntityStates, IHasRoleEfforts
    {
        public bool CanChangeOwner { get; set; }
        public bool HasEffort { get; set; }

        #region Required for Create

        [RequiredForCreate]
        public string Name { get; set; }

        #endregion

        public Collection<EntityState> EntityStates { get; set; }
        public Collection<RoleEffort> RoleEfforts { get; set; }
    }
}