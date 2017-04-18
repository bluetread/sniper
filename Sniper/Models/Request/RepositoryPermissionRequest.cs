#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Request
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class RepositoryPermissionRequest
    {
        /// <summary>
        /// Used to add or update a team repository.
        /// </summary>
        public RepositoryPermissionRequest(Permission permission)
        {
            Permission = permission;
        }

        /// <summary>
        /// The permission to grant the team on this repository.
        /// </summary>        
        public Permission Permission { get; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Permission: {0}", Permission);
    }
}
#endif