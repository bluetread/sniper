using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Delivering an increment(s) of product functionality to public. Release contains several Iterations.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Releases/meta">API documentation - Release</a>
    /// </remarks>
    public class Release : General, IHasCurrent, IHasForecastEndDate, IHasProcess, IHasProgress, IHasUnits,
        IHasCommonEntityCollections, IHasBuilds, IHasIterations, IHasProjects, IHasTestPlanRuns
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public bool IsCurrent { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? ForecastEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Progress { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Units { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Process Process { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Build> Builds { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Epic> Epics { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Feature> Features { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Iteration> Iterations { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Project> Projects { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Task> Tasks { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> TestPlan { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; set; }
    }
}