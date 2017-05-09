using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    public abstract class IterationBase : General, ICanBeFinished, IHasCurrent, IHasDuration, IHasForecastEndDate,
        IHasProgress, IHasCommonCollections, IHasUnits, IHasVelocity
    {
        [JsonProperty(Required = Required.Default)]
        public bool CanBeFinished { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsCurrent { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int Duration { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? ForecastEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Progress { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Units { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Velocity { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Task> Tasks { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; set; }
    }
}