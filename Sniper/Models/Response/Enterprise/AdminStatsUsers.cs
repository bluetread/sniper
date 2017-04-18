#if false
using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class AdminStatsUsers
    {
        public AdminStatsUsers() { }

        public AdminStatsUsers(int totalUsers, int adminUsers, int suspendedUsers)
        {
            TotalUsers = totalUsers;
            AdminUsers = adminUsers;
            SuspendedUsers = suspendedUsers;
        }

        public int TotalUsers
        {
            get;
        }

        public int AdminUsers
        {
            get;
        }

        public int SuspendedUsers
        {
            get;
        }

        internal string DebuggerDisplay => String.Format(CultureInfo.InvariantCulture, "TotalUsers: {0} AdminUsers: {1} SuspendedUsers: {2}", TotalUsers, AdminUsers, SuspendedUsers);
    }
}
#endif