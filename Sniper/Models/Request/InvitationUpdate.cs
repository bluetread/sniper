using System.Diagnostics;
using System.Globalization;
using Sniper.Response;

namespace Sniper.Request
{
    /// <summary>
    /// Used to update a invitation.
    /// </summary>
    /// <remarks>    
    /// </remarks>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class InvitationUpdate
    {
        public InvitationUpdate(InvitationPermissionType permission)
        {
            Permissions = permission;
        }

        public InvitationPermissionType Permissions { get; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Permission: {0}", Permissions);
            }
        }
    }
}
