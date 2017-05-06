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
        public bool IsCurrent { get; set; }
        public DateTime? ForecastEndDate { get; set; }
        public decimal Progress { get; set; }
        public string Units { get; set; }

        #region Required for Create

        [RequiredForCreate]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public override Project Project { get; set; }

        #endregion

        public Process Process { get; set; }

        public Collection<Assignable> Assignables { get; set; }
        public Collection<Build> Builds { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<Epic> Epics { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<Iteration> Iterations { get; set; }
        public Collection<Project> Projects { get; set; }
        public Collection<Request> Requests { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<TestPlan> TestPlan { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<UserStory> UserStories { get; set; }
    }
}