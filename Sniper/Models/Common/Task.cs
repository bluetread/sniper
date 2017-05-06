using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using Sniper.Contracts.Entities.History;
using Sniper.History;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

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
        #region Required for Create

        [RequiredForCreate]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public override Project Project { get; set; }

        #endregion

        public UserStory UserStory { get; set; }
        public Collection<TaskSimpleHistory> History { get; set; }
    }
}