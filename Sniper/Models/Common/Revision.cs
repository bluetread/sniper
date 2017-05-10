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
    [CanCreateReadUpdateDelete]
    public class Revision : Entity, IHasDescription, IHasProject, IHasRevisionFiles, IHasAssignables
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string SourceControlId { get; internal set; }

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Project Project { get; internal set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime CommitDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public User Author { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<RevisionFile> RevisionFiles { get; internal set; }
    }
}