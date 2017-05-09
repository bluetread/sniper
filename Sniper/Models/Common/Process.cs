using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Set of practices, terms, workflows and custom fields that can be applied to Project.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Processes/meta">API documentation - Process</a>
    /// </remarks>
    public class Process : Entity, IHasName, IHasDescription, IHasProjects,
        IHasPractices, IHasCustomFields, IHasProcessAdmins, IHasTerms, IHasWorkFlows
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<CustomField> CustomFields { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Practice> Practices { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<User> ProcessAdmins { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Project> Projects { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Term> Terms { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Workflow> Workflows { get; set; }
    }
}