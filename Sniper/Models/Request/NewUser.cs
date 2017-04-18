#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Request
{
    /// <summary>
    /// Describes a new user to create via the <see cref="IUserAdministrationClient.Create(NewUser)"/> method.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class NewUser
    {
        public NewUser() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUser"/> class.
        /// </summary>
        /// <param name="login">The login for the user.</param>
        /// <param name="email">The email address of the user</param>
        public NewUser(string login, string email)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(login), login);
            Ensure.ArgumentNotNullOrEmptyString(nameof(email), email);

            Login = login;
            Email = email;
        }

        /// <summary>
        /// Login of the user
        /// </summary>
        public string Login { get; protected set; }

        /// <summary>
        /// Email address of the user
        /// </summary>
        public string Email { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Login: {0} Email: {1}", Login, Email);
    }
}
#endif