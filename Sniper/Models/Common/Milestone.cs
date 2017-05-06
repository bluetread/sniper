using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    /// <summary>
    /// Milestones for projects
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Milestones/meta">API documentation - Milestone</a>
    /// </remarks>
    public class Milestone : Entity, IHasName, IHasDescription, IHasDate, IHasProjects
    {
        public string CssClass { get; set; }
        public string Description { get; set; }

        [JsonProperty(JsonProperties.Date)]
        public DateTime? EntryDate { get; set; }

        public string Name { get; set; }
        public User Owner { get; set; }
        public Collection<Project> Projects { get; set; }
    }
}