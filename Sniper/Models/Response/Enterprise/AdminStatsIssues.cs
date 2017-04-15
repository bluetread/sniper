using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class AdminStatsIssues
    {
        public AdminStatsIssues() { }

        public AdminStatsIssues(int totalIssues, int openIssues, int closedIssues)
        {
            TotalIssues = totalIssues;
            OpenIssues = openIssues;
            ClosedIssues = closedIssues;
        }

        public int TotalIssues
        {
            get;
        }

        public int OpenIssues
        {
            get;
        }

        public int ClosedIssues
        {
            get;
        }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "TotalIssues: {0} OpenIssues: {1} ClosedIssues: {2}", TotalIssues, OpenIssues, ClosedIssues);
            }
        }
    }
}