using Sniper.Contracts;

namespace Sniper.Common
{
    /// <summary>
    /// Inbound relation for Assignable.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/InboundAssignables/meta">API documentation - InboundAssignable</a>
    /// </remarks>
    public class InboundAssignable : Assignable, IHasRelationType
    {
        public General OutboundGeneral { get; set; }
        public RelationType RelationType { get; set; }
    }
}