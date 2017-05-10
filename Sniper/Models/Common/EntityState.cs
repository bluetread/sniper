using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// State of Entity. Collection of EntityStates form Workflow for Entity. For example, Bug has four EntityStates by default: Open, Fixed, Invalid and Done.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/EntityStates/meta">API documentation - EntityState</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class EntityState : Entity, IHasName, IHasRole, IHasProjects, IHasAssignables
    {

        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public bool IsCommentRequired { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsFinal { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsInitial { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsPlanned { get; set; }

        [JsonProperty(Required = Required.Default)]
        public double NumericPriority { get; set; }

        [JsonProperty(Required = Required.Default)]
        public EntityState ParentEntityState { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Role Role { get; set; }

        [JsonProperty(Required = Required.DisallowNull)]
        public Workflow Workflow { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<EntityState> NextStates { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<EntityState> PreviousStates { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Project> Projects { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<EntityState> SubEntityStates { get; internal set; }
    }
}