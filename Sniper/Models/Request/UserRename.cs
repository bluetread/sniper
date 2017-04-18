#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Request
{
    /// <summary>
    /// Describes the new login when renaming a user via the <see cref="IUserAdministrationClient.Rename(string, UserRename)"/> method.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class UserRename
    {
        public UserRename() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRename"/> class.
        /// </summary>
        /// <param name="login">The new login for the user.</param>
        public UserRename(string login)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(login), login);

            Login = login;
        }

        /// <summary>
        /// The new username for the user
        /// </summary>
        public string Login { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Login: {0}", Login);
    }
}
#endif