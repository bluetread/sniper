#if false
using System.Diagnostics;
using System.Globalization;
using Sniper.Response;

namespace Sniper.Request
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class RepositoryTrafficRequest : RequestParameters
    {
        public RepositoryTrafficRequest() { }

        public RepositoryTrafficRequest(TrafficDayOrWeek per)
        {
            Per = per;
        }

        public TrafficDayOrWeek Per { get; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Per: {0}", Per);
    }
}
#endif