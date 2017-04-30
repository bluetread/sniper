using Sniper.Contracts;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// A group of TestCases. For example, you can create 'Smoke Tests' TestPlan and add TestCases there.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestPlans/meta">API documentation - TestPlan</a>
    /// </remarks>
    public class TestPlan : Assignable, IHasInitialEstimate, IHasRevisions, IHasTestCases,
        IHasTestPlanRuns, IHasRoleEfforts, IHasUserStories
    {
        public decimal CalculatedEstimate { get; set; }
        public decimal InitialEstimate { get; set; }

        public Assignable LinkedAssignable { get; set; }
        public Bug LinkedBug { get; set; }
        public Build LinkedBuild { get; set; }
        public Epic LinkedEpic { get; set; }
        public Feature LinkedFeature { get; set; }
        public General LinkedGeneral { get; set; }
        public Iteration LinkedIteration { get; set; }
        public Release LinkedRelease { get; set; }
        public Request LinkedRequest { get; set; }
        public Task LinkedTask { get; set; }
        public TeamIteration LinkedTeamIteration { get; set; }
        public UserStory LinkedUserStory { get; set; }

        public Collection<TestCase> TestCases { get; set; }
        public Collection<TestPlan> ChildTestPlans { get; set; }
        public Collection<TestPlan> ParentTestPlans { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<UserStory> UserStories { get; set; }
    }
}