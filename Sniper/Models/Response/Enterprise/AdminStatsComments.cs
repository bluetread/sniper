using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class AdminStatsComments
    {
        public AdminStatsComments() { }

        public AdminStatsComments(int totalCommitComments, int totalIssueComments, int totalPullRequestComments)
        {
            TotalCommitComments = totalCommitComments;
            TotalIssueComments = totalIssueComments;
            TotalPullRequestComments = totalPullRequestComments;
        }

        public int TotalCommitComments
        {
            get;
        }

        public int TotalIssueComments
        {
            get;
        }

        public int TotalPullRequestComments
        {
            get;
        }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "TotalCommitComments: {0} TotalIssueComments: {1} TotalPullRequestComments: {2}", TotalCommitComments, TotalIssueComments, TotalPullRequestComments);
            }
        }
    }
}