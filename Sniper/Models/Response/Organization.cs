#if false
using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class Organization : Account
    {
        public Organization() { }

        public Organization(string avatarUrl, string bio, string blog, string company, DateTimeOffset createdAt, int diskUsage, string email, string htmlUrl, int id, string location, string login, string name, string url, string billingAddress)
            : base(avatarUrl, bio, blog, company, createdAt, diskUsage, email, htmlUrl, id, location, login, name, AccountType.Organization, url)
        {
            BillingAddress = billingAddress;
        }

        /// <summary>
        /// The billing address for an organization. This is only returned when updating 
        /// an organization.
        /// </summary>
        public string BillingAddress { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture,
            "Organization: Id: {0} Login: {1}", Id, Login);
    }
}
#endif