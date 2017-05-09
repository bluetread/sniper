using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Core entity which contains Releases, Features, User Stories, Bugs, etc.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Projects/meta">API documentation - Project</a>
    /// </remarks>
    public class Project : General, IHasActive, IHasAllocations, IHasBugs, IHasBuilds,
        IHasCompany, IHasCustomActivities, IHasEffort, IHasEntityState, IHasEpics,
        IHasFeatures, IHasForecastEndDate, IHasGenerals, IHasIterations, IHasLeadCycleTimes,
        IHasMilestones, IHasPlannedDates, IHasPrivate, IHasProgress, IHasProjectMembers,
        IHasReleases, IHasRequests, IHasRevisions, IHasTasks, IHasTeamProjects,
        IHasTestCases, IHasTestPlanRuns, IHasTestPlans, IHasTimes, IHasUnits, IHasUserStories
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public EntityState EntityState { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string Abbreviation { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? AnticipatedEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Color { get; set; }

        [JsonProperty(Required = Required.Default)]
        public double CycleTime { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Effort { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortCompleted { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortToDo { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? ForecastEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsActive { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsPrivate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsProduct { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? LastStateChangeDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public double LeadTime { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string MailReplyAddress { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Progress { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? PlannedEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? PlannedStartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Units { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Company Company { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Process Process { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Program Program { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<ProjectAllocation> Allocations { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Build> Builds { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Release> CrossProjectReleases { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<CustomActivity> CustomActivities { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Epic> Epics { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Feature> Features { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<General> Generals { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Iteration> Iterations { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Milestone> Milestones { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<ProjectMember> ProjectMembers { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Release> Releases { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Revision> Revisions { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Task> Tasks { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamProject> TeamProjects { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestCase> TestCases { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> TestPlan { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Time> Times { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; set; }
    }
}