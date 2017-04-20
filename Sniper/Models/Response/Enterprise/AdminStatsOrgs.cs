#if false
using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class AdminStatsOrgs
    {
        public AdminStatsOrgs() { }

        public AdminStatsOrgs(int totalOrgs, int disabledOrgs, int totalTeams, int totalTeamMembers)
        {
            TotalOrgs = totalOrgs;
            DisabledOrgs = disabledOrgs;
            TotalTeams = totalTeams;
            TotalTeamMembers = totalTeamMembers;
        }

        public int TotalOrgs
        {
            get;
        }

        public int DisabledOrgs
        {
            get;
        }

        public int TotalTeams
        {
            get;
        }

        public int TotalTeamMembers
        {
            get;
        }

        internal string DebuggerDisplay => String.Format(CultureInfo.InvariantCulture, "TotalOrgs: {0} DisabledOrgs: {1} TotalTeams: {2} TotalTeamMembers: {3}", TotalOrgs, DisabledOrgs, TotalTeams, TotalTeamMembers);
    }
}
#endif