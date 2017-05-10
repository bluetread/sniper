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
    [CanCreateReadUpdateDelete]
    public class Release : General, IHasCurrent, IHasForecastEndDate, IHasProcess, IHasProgress, IHasUnits,
        IHasCommonEntityCollections, IHasBuilds, IHasIterations, IHasProjects, IHasTestPlanRuns
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public bool IsCurrent { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? ForecastEndDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Progress { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string Units { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Process Process { get; internal set; }

        #region Collections

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Build> Builds { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Epic> Epics { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Feature> Features { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Iteration> Iterations { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Project> Projects { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Task> Tasks { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> TestPlan { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; internal set; }

        #endregion
    }
}