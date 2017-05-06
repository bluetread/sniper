using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// A single TestPlan Run. TestPlan can have multiple runs by various Iterations, Releases or Builds.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestPlanRuns/meta">API documentation - TestPlanRun</a>
    /// </remarks>
    public class TestPlanRun : Assignable, IHasBuild, IHasTestPlan, IHasTestCaseRuns, IHasTestPlanRuns,
        IHasBugs, IHasTestCaseRunLinks
    {
        public int BlockedCount { get; set; }
        public int FailedCount { get; set; }
        public bool IsLastStarted { get; set; }
        public int NotRunCount { get; set; }
        public int OnHoldCount { get; set; }
        public int PassedCount { get; set; }

        #region Required for Create

        [RequiredForCreate]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public override Project Project { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public TestPlan TestPlan { get; set; }

        #endregion

        public Build Build { get; set; }
        public TestPlanRun ParentTestPlanRun { get; set; }

        public Collection<Bug> Bugs { get; set; }
        public Collection<TestCaseRun> TestCaseRun { get; set; }
        public Collection<TestRunItemHierarchyLink> TestCaseRunLinks { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
    }
}