using System.Collections.Generic;
using System.Diagnostics;

namespace Sniper.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchCodeResult : SearchResult<SearchCode>
    {
        public SearchCodeResult() { }

        public SearchCodeResult(int totalCount, bool incompleteResults, IReadOnlyList<SearchCode> items) : base(totalCount, incompleteResults, items) {}
    }
}