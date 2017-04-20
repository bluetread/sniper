#if false
using System.Collections.Generic;
using System.Diagnostics;

namespace Sniper.Response
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class SearchUsersResult : SearchResult<User>
    {
        public SearchUsersResult() { }

        public SearchUsersResult(int totalCount, bool incompleteResults, IReadOnlyList<User> items)
            : base(totalCount, incompleteResults, items)
        {
        }
    }
}
#endif