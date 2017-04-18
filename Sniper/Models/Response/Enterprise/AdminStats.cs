using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class AdminStats
    {
        public AdminStats() { }

        public AdminStats(AdminStatsRepos repos, AdminStatsPages pages, AdminStatsOrgs orgs, AdminStatsUsers users, AdminStatsIssues issues, AdminStatsMilestones milestones, AdminStatsComments comments)
        {
            Repos = repos;
            Pages = pages;
            Orgs = orgs;
            Users = users;
            Issues = issues;
            Milestones = milestones;
            Comments = comments;
        }

        public AdminStatsRepos Repos
        {
            get;
        }


        public AdminStatsPages Pages
        {
            get;
        }

        public AdminStatsOrgs Orgs
        {
            get;
        }

        public AdminStatsUsers Users
        {
            get;
        }

        public AdminStatsIssues Issues
        {
            get;
        }

        public AdminStatsMilestones Milestones
        {
            get;
        }

        public AdminStatsComments Comments
        {
            get;
        }

        internal string DebuggerDisplay
        {
            get
            {
                string fieldsPresent = string.Concat(
                    Repos != null ? "Repos," : string.Empty,
                    Pages != null ? "Pages," : string.Empty,
                    Orgs != null ? "Orgs," : string.Empty,
                    Users != null ? "Users," : string.Empty,
                    Issues != null ? "Issues," : string.Empty,
                    Milestones != null ? "Milestones," : string.Empty,
                    Comments != null ? "Comments," : string.Empty
                    ).Trim(',');

                return String.Format(CultureInfo.InvariantCulture, "Statistics: {0}", fieldsPresent);
            }
        }
    }
}