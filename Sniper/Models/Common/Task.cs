using Sniper.Contracts;
using Sniper.Contracts.History;
using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// A small chunk of work, typically less than 16 hours. Task must relate to User Story.
    /// It is not possible to create Tasks without User Story.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Tasks/meta">API documentation - Task</a>
    /// </remarks>
    public class Task : Assignable, IHasUserStory, IHasTaskHistory
    {
        public UserStory UserStory { get; set; }
        public Collection<TaskSimpleHistory> History { get; set; }
    }
}