using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using Sniper.Application;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Set of states
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Workflows/meta">API documentation - Workflow</a>
    /// </remarks>
    public class Workflow : Entity, IHasName, IHasEntityType, IHasProcess, IHasEntityStates, IHasTeamProjects
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public EntityType EntityType { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Process Process { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Workflow ParentWorkflow { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public Collection<EntityState> EntityStates { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Workflow> SubWorkflows { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamProject> TeamProjects { get; set; }
    }
}