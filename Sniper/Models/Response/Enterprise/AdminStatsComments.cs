using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class AdminStatsComments
    {
        public AdminStatsComments() { }

        public AdminStatsComments(int totalCommitComments, int totalGistComments, int totalIssueComments, int totalPullRequestComments)
        {
            TotalCommitComments = totalCommitComments;
            TotalGistComments = totalGistComments;
            TotalIssueComments = totalIssueComments;
            TotalPullRequestComments = totalPullRequestComments;
        }

        public int TotalCommitComments
        {
            get;
        }

        public int TotalGistComments
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
                return String.Format(CultureInfo.InvariantCulture, "TotalCommitComments: {0} TotalGistComments: {1} TotalIssueComments: {2} TotalPullRequestComments: {3}", TotalCommitComments, TotalGistComments, TotalIssueComments, TotalPullRequestComments);
            }
        }
    }
}