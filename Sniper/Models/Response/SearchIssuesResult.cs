using System.Collections.Generic;
using System.Diagnostics;

namespace Sniper.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchIssuesResult : SearchResult<Issue>
    {
        public SearchIssuesResult() { }

        public SearchIssuesResult(int totalCount, bool incompleteResults, IReadOnlyList<Issue> items)
            : base(totalCount, incompleteResults, items)
        {
        }
    }
}