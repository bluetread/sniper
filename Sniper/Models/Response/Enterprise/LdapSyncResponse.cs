using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class LdapSyncResponse
    {
        public LdapSyncResponse() { }

        public LdapSyncResponse(string status)
        {
            Status = status;
        }

        public string Status
        {
            get;
        }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "Status: {0}", Status);
            }
        }
    }
}
