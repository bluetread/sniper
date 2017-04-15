using System.Diagnostics;

namespace Sniper.Response.ActivityPayloads
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class IssueEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public Issue Issue { get; protected set; }
    }
}
