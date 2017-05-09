using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
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
        [JsonProperty(Required = Required.Default)]
        public decimal CalculatedEstimate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal InitialEstimate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Assignable LinkedAssignable { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Bug LinkedBug { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Build LinkedBuild { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Epic LinkedEpic { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Feature LinkedFeature { get; set; }

        [JsonProperty(Required = Required.Default)]
        public General LinkedGeneral { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Iteration LinkedIteration { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Release LinkedRelease { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Request LinkedRequest { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Task LinkedTask { get; set; }

        [JsonProperty(Required = Required.Default)]
        public TeamIteration LinkedTeamIteration { get; set; }

        [JsonProperty(Required = Required.Default)]
        public UserStory LinkedUserStory { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestCase> TestCases { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> ChildTestPlans { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> ParentTestPlans { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; set; }
    }
}