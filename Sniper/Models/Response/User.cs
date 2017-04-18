#if false
using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    /// <summary>
    /// Represents a user on GitHub.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class User : Account
    {
        public User() { }

        public User(string avatarUrl, string bio, string blog, string company, DateTimeOffset createdAt, int diskUsage, string email, string htmlUrl, int id, string location, string login, string name, string url, RepositoryPermissions permissions, bool siteAdmin, string ldapDistinguishedName, DateTimeOffset? suspendedAt)
            : base(avatarUrl, bio, blog, company, createdAt, diskUsage, email, htmlUrl, id, location, login, name, AccountType.User, url)
        {
            Permissions = permissions;
            SiteAdmin = siteAdmin;
            LdapDistinguishedName = ldapDistinguishedName;
            SuspendedAt = suspendedAt;
        }

        public RepositoryPermissions Permissions { get; protected set; }

        /// <summary>
        /// Whether or not the user is an administrator of the site
        /// </summary>
        public bool SiteAdmin { get; protected set; }

        /// <summary>
        /// When the user was suspended, if at all (GitHub Enterprise)
        /// </summary>
        public DateTimeOffset? SuspendedAt { get; protected set; }

        /// <summary>
        /// Whether or not the user is currently suspended
        /// </summary>
        public bool Suspended => SuspendedAt.HasValue;

        /// <summary>
        /// LDAP Binding (GitHub Enterprise only)
        /// </summary>
        [Parameter(Key = "ldap_dn")]
        public string LdapDistinguishedName { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture,
            "User: Id: {0} Login: {1}", Id, Login);
    }
}
#endif