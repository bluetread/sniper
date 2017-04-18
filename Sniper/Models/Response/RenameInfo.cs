#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class RenameInfo
    {
        public string From { get; protected set; }
        public string To { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "From: {0} To: {1}", From, To);
    }
}
#endif