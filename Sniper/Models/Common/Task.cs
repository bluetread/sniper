using Newtonsoft.Json;
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
    [CanCreateReadUpdateDelete]
    public class Task : Assignable, IHasUserStory, IHasTaskHistory
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public UserStory UserStory { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public Collection<TaskSimpleHistory> History { get; internal set; }
    }
}