using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class AdminStats
    {
        public AdminStats() { }

        public AdminStats(AdminStatsRepos repos, AdminStatsHooks hooks, AdminStatsPages pages, AdminStatsOrgs orgs, AdminStatsUsers users, AdminStatsPulls pulls, AdminStatsIssues issues, AdminStatsMilestones milestones, AdminStatsGists gists, AdminStatsComments comments)
        {
            Repos = repos;
            Hooks = hooks;
            Pages = pages;
            Orgs = orgs;
            Users = users;
            Pulls = pulls;
            Issues = issues;
            Milestones = milestones;
            Gists = gists;
            Comments = comments;
        }

        public AdminStatsRepos Repos
        {
            get;
        }

        public AdminStatsHooks Hooks
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

        public AdminStatsPulls Pulls
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

        public AdminStatsGists Gists
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
                string fieldsPresent = String.Concat(
                    Repos != null ? "Repos," : "",
                    Hooks != null ? "Hooks," : "",
                    Pages != null ? "Pages," : "",
                    Orgs != null ? "Orgs," : "",
                    Users != null ? "Users," : "",
                    Pulls != null ? "Pulls," : "",
                    Issues != null ? "Issues," : "",
                    Milestones != null ? "Milestones," : "",
                    Gists != null ? "Gists," : "",
                    Comments != null ? "Comments," : ""
                    ).Trim(',');

                return String.Format(CultureInfo.InvariantCulture, "Statistics: {0}", fieldsPresent);
            }
        }
    }
}