using Newtonsoft.Json;
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
    [CanCreateReadUpdateDelete]
    public class TestPlanRun : Assignable, IHasBuild, IHasTestPlan, IHasTestCaseRuns, IHasTestPlanRuns,
        IHasBugs, IHasTestCaseRunLinks
    {

        #region Required for Create

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState, 
            JsonProperties.Project, JsonProperties.Priority)]
        [JsonProperty(Required = Required.DisallowNull)]
        public TestPlan TestPlan { get; set; }

        #endregion

        public int BlockedCount { get; internal set; }
        public int FailedCount { get; internal set; }
        public bool IsLastStarted { get; internal set; }
        public int NotRunCount { get; internal set; }
        public int OnHoldCount { get; internal set; }
        public int PassedCount { get; internal set; }
        public Build Build { get; set; }
        public TestPlanRun ParentTestPlanRun { get; internal set; }

        public Collection<Bug> Bugs { get; internal set; }
        public Collection<TestCaseRun> TestCaseRun { get; internal set; }
        public Collection<TestRunItemHierarchyLink> TestCaseRunLinks { get; internal set; }
        public Collection<TestPlanRun> TestPlanRuns { get; internal set; }
    }
}