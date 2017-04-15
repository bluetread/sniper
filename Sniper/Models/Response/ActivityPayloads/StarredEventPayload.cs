using System.Diagnostics;

namespace Sniper.Response.ActivityPayloads
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class StarredEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
    }
}
