using System;
using System.Collections.ObjectModel;
using Sniper.Contracts;

namespace Sniper.Common
{
    public abstract class IterationBase : General, ICanBeFinished, IHasCurrent, IHasDuration, IHasForecastEndDate,
        IHasProgress, IHasCommonCollections, IHasUnits, IHasVelocity
    {
        public bool CanBeFinished { get; set; }
        public bool IsCurrent { get; set; }
        public int Duration { get; set; }
        public DateTime? ForecastEndDate { get; set; }
        public decimal Progress { get; set; }
        public string Units { get; set; }
        public decimal Velocity { get; set; }

        public Collection<Assignable> Assignables { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<UserStory> UserStories { get; set; }
        
    }
}
