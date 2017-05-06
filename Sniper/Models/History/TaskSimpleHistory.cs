using Sniper.Common;
using Sniper.Contracts.Entities.Common;

namespace Sniper.History
{
    ///<summary>
    /// A change of an entity
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TaskSimpleHistories/meta">API documentation - TaskSimpleHistory</a>
    /// </remarks>
    public class TaskSimpleHistory : SimpleHistoryExtendedBase, IHasTask
    {
        public Task Task { get; set; }
    }
}