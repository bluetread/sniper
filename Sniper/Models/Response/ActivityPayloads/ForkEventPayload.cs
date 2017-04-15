using System.Diagnostics;

namespace Sniper.Response.ActivityPayloads
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class ForkEventPayload : ActivityPayload
    {
        public Repository Forkee { get; protected set; }
    }
}
