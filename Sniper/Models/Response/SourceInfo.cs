#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class SourceInfo
    {
        public User Actor { get; protected set; }
        public int Id { get; protected set; }
        public string Url { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Id: {0} Url: {1}", Id, Url ?? "");
    }
}
#endif