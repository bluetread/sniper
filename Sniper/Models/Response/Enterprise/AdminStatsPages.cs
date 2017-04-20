#if false
using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class AdminStatsPages
    {
        public AdminStatsPages() { }

        public AdminStatsPages(int totalPages)
        {
            TotalPages = totalPages;
        }

        public int TotalPages
        {
            get;
        }

        internal string DebuggerDisplay => String.Format(CultureInfo.InvariantCulture, "TotalPages: {0}", TotalPages);
    }
}
#endif