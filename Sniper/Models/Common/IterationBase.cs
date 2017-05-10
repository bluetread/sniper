using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    public abstract class IterationBase : General, ICanBeFinished, IHasCurrent, IHasDuration, IHasForecastEndDate,
        IHasProgress, IHasCommonCollections, IHasUnits, IHasVelocity
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override DateTime? EndDate { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override DateTime? StartDate { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public bool CanBeFinished { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsCurrent { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public int Duration { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? ForecastEndDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Progress { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string Units { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Velocity { get; set; }

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.Default)]
        public override Project Project { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Task> Tasks { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; internal set; }
    }
}