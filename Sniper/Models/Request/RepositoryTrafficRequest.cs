using System.Diagnostics;
using System.Globalization;
using Sniper.Response;

namespace Sniper.Request
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class RepositoryTrafficRequest : RequestParameters
    {
        public RepositoryTrafficRequest() { }

        public RepositoryTrafficRequest(TrafficDayOrWeek per)
        {
            Per = per;
        }

        public TrafficDayOrWeek Per { get; }

        internal string DebuggerDisplay
        {
            get { return string.Format(CultureInfo.InvariantCulture, "Per: {0}", Per); }
        }
    }
}
