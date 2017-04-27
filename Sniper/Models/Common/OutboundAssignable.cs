using Sniper.Contracts;

namespace Sniper.Common
{
    /// <summary>
    /// Outbound relation for Assignable.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/OutboundAssignables/meta">API documentation - OutboundAssignable</a>
    /// </remarks>
    public class OutboundAssignable : Assignable, IHasRelationType
    {
        public General InboundGeneral { get; set; }
        public RelationType RelationType { get; set; }
    }
}