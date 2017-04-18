using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using Sniper.ToBeRemoved;

namespace Sniper.Request
{
    /// <summary>
    /// Searching Issues
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchIssuesRequest : BaseSearchRequest
    {
        /// <summary>
        /// Search without specifying a keyword
        /// </summary>
        public SearchIssuesRequest()
        {
            Repos = new RepositoryCollection();
        }

        /// <summary>
        /// Search using a specify keyword
        /// </summary>
        /// <param name="term">The term to filter on</param>
        public SearchIssuesRequest(string term) : base(term)
        {
            Repos = new RepositoryCollection();
        }


    
        /// <summary>
        /// Finds issues created by a certain user.
        /// </summary>
        /// <remarks>
        /// https://help.github.com/articles/searching-issues/#search-by-the-author-of-an-issue-or-pull-request
        /// </remarks>
        public string Author { get; set; }

        /// <summary>
        /// Finds issues that are assigned to a certain user.
        /// </summary>
        /// <remarks>
        /// https://help.github.com/articles/searching-issues/#search-by-the-assignee-of-an-issue-or-pull-request
        /// </remarks>
        public string Assignee { get; set; }

        /// <summary>
        /// Finds issues that mention a certain user.
        /// </summary>
        /// <remarks>
        /// https://help.github.com/articles/searching-issues/#search-by-a-mentioned-user-within-an-issue-or-pull-request
        /// </remarks>
        public string Mentions { get; set; }

        /// <summary>
        /// Finds issues that a certain user commented on.
        /// </summary>
        /// <remarks>
        /// https://help.github.com/articles/searching-issues/#search-by-a-commenter-within-an-issue-or-pull-request
        /// </remarks>
        public string Commenter { get; set; }


      

       

       

    

     


        /// <summary>
        /// Limits searches to repositories owned by a certain user or organization.
        /// </summary>
        /// <remarks>
        /// https://help.github.com/articles/searching-issues/#search-within-a-users-or-organizations-repositories
        /// </remarks>
        public string User { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public RepositoryCollection Repos { get; set; }

        public SearchIssuesRequestExclusions Exclusions { get; set; }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override IReadOnlyList<string> MergedQualifiers()
        {
            var parameters = new List<string>();

           

            if (Author.IsNotBlank())
            {
                parameters.Add(string.Format(CultureInfo.InvariantCulture, "author:{0}", Author));
            }

            if (Assignee.IsNotBlank())
            {
                parameters.Add(string.Format(CultureInfo.InvariantCulture, "assignee:{0}", Assignee));
            }

            if (Mentions.IsNotBlank())
            {
                parameters.Add(string.Format(CultureInfo.InvariantCulture, "mentions:{0}", Mentions));
            }

            if (Commenter.IsNotBlank())
            {
                parameters.Add(string.Format(CultureInfo.InvariantCulture, "commenter:{0}", Commenter));
            }

            if (User.IsNotBlank())
            {
                parameters.Add(string.Format(CultureInfo.InvariantCulture, "user:{0}", User));
            }

            if (Repos.Any())
            {
                var invalidFormatRepos = Repos.Where(x => !x.IsNameWithOwnerFormat());
                if (invalidFormatRepos.Any())
                {
                    throw new RepositoryFormatException(invalidFormatRepos);
                }

                parameters.AddRange(Repos.Select(x => string.Format(CultureInfo.InvariantCulture, "repo:{0}", x)));
            }

            // Add any exclusion parameters
            if (Exclusions != null)
            {
                parameters.AddRange(Exclusions.MergedQualifiers());
            }

            return new ReadOnlyCollection<string>(parameters);
        }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Search: {0} {1}", Term, string.Join(" ", MergedQualifiers()));
            }
        }
    }

    public enum IssueSearchSort
    {
        /// <summary>
        /// search by number of comments
        /// </summary>
        [Parameter(Value = "comments")]
        Comments,
        /// <summary>
        /// search by created
        /// </summary>
        [Parameter(Value = "created")]
        Created,
        /// <summary>
        /// search by last updated
        /// </summary>
        [Parameter(Value = "updated")]
        Updated
    }

   

    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class RepositoryCollection : Collection<string>
    {
        public void Add(string owner, string name)
        {
            Add(GetRepositoryName(owner, name));
        }

        public bool Contains(string owner, string name)
        {
            return Contains(GetRepositoryName(owner, name));
        }

        public bool Remove(string owner, string name)
        {
            return Remove(GetRepositoryName(owner, name));
        }

        private static string GetRepositoryName(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);

            return string.Format(CultureInfo.InvariantCulture, "{0}/{1}", owner, name);
        }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Repositories: {0}", Count);
            }
        }
    }
}
