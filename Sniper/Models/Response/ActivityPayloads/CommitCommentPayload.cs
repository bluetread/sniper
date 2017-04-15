using System.Diagnostics;

namespace Sniper.Response.ActivityPayloads
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class CommitCommentPayload : ActivityPayload
    {
        public CommitComment Comment { get; protected set; }
    }
}
