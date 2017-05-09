using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// A single commit into repository. Contains a set of source files.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Revisions/meta">API documentation - Revision</a>
    /// </remarks>
    public class Revision : Entity, IHasDescription, IHasProject, IHasRevisionFiles, IHasAssignables
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string SourceControlId { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Project Project { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime CommitDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public User Author { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<RevisionFile> RevisionFiles { get; set; }
    }
}