using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;

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
        public string Abbreviation { get; set; }
        public DateTime? AnticipatedEndDate { get; set; }
        public string Color { get; set; }
        public double CycleTime { get; set; }
        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public DateTime? ForecastEndDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsProduct { get; set; }
        public DateTime? LastStateChangeDate { get; set; }
        public double LeadTime { get; set; }
        public string MailReplyAddress { get; set; }
        public decimal Progress { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public string Units { get; set; }

        public Company Company { get; set; }
        public Process Process { get; set; }
        public Program Program { get; set; }
        public EntityState EntityState { get; set; }

        public Collection<ProjectAllocation> Allocations { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<Build> Builds { get; set; }
        public Collection<Release> CrossProjectReleases { get; set; }
        public Collection<CustomActivity> CustomActivities { get; set; }
        public Collection<Epic> Epics { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<General> Generals { get; set; }
        public Collection<Iteration> Iterations { get; set; }
        public Collection<Milestone> Milestones { get; set; }
        public Collection<ProjectMember> ProjectMembers { get; set; }
        public Collection<Release> Releases { get; set; }
        public Collection<Request> Requests { get; set; }
        public Collection<Revision> Revisions { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<TeamProject> TeamProjects { get; set; }
        public Collection<TestCase> TestCases { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<TestPlan> TestPlan { get; set; }
        public Collection<Time> Times { get; set; }
        public Collection<UserStory> UserStories { get; set; }
    }
}