using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Milestones for projects
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Milestones/meta">API documentation - Milestone</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Milestone : Entity, IHasName, IHasDescription, IHasDate, IHasProjects
    {
        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string CssClass { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(JsonProperties.Date, Required = Required.Default)]
        public DateTime? EntryDate { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public User Owner { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Project> Projects { get; internal set; }
    }
}