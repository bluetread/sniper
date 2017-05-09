using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
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
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public bool CanChangeOwner { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool HasEffort { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<EntityState> EntityStates { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<RoleEffort> RoleEfforts { get; set; }
    }
}