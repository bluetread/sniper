using Sniper.Common;
using Sniper.Contracts;

namespace Sniper.History
{
    ///<summary>
    /// A change of an entity
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/UserStorySimpleHistories/meta">API documentation - UserStorySimpleHistory</a>
    /// </remarks>
    public class UserStorySimpleHistory : SimpleHistoryExtendedBase, IHasUserStory
    {
        public UserStory UserStory { get; set; }
    }
}