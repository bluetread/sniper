using System.Diagnostics;
using System.Globalization;
using Sniper.Enterprise;

namespace Sniper.Request.Enterprise
{
    /// <summary>
    /// Describes a new organization to create via the <see cref="IEnterpriseOrganizationClient.Create" /> method.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class NewLdapMapping
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewLdapMapping"/> class.
        /// </summary>
        /// <param name="ldapDistinguishedName">The LDAP Distinguished Name</param>
        public NewLdapMapping(string ldapDistinguishedName)
        {
            Ensure.ArgumentNotNullOrEmptyString(ldapDistinguishedName, "ldapDistinguishedName");

            LdapDistinguishedName = ldapDistinguishedName;
        }

        /// <summary>
        /// The LDAP Distinguished Name (required)
        /// </summary>
        [Parameter(Key = "ldap_dn")]
        public string LdapDistinguishedName { get; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "LdapDistinguishedName: {0}", LdapDistinguishedName);
            }
        }
    }
}
