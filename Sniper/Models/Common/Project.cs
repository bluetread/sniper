using Newtonsoft.Json;
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
    [CanCreateReadUpdateDelete]
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

        //[RequiredForCreate(JsonProperties.Name)]
        //[JsonProperty(Required = Required.DisallowNull)]
        [JsonProperty(Required = Required.Default)]
        public EntityState EntityState { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string Abbreviation { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? AnticipatedEndDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string Color { get; set; }

        [JsonProperty(Required = Required.Default)]
        public double CycleTime { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Effort { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortCompleted { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal EffortToDo { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? ForecastEndDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsActive { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsPrivate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsProduct { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? LastStateChangeDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public double LeadTime { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string MailReplyAddress { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Progress { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? PlannedEndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? PlannedStartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Units { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        //[RequiredForCreate(JsonProperties.Name)]
        public Company Company { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Process Process { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Program Program { get; set; }

        #region Collections

        [JsonProperty(Required = Required.Default)]
        public Collection<ProjectAllocation> Allocations { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Build> Builds { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Release> CrossProjectReleases { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<CustomActivity> CustomActivities { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Epic> Epics { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Feature> Features { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<General> Generals { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Iteration> Iterations { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Milestone> Milestones { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<ProjectMember> ProjectMembers { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Release> Releases { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Revision> Revisions { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Task> Tasks { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamProject> TeamProjects { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestCase> TestCases { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> TestPlan { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Time> Times { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; internal set; }

        #endregion
    }
}