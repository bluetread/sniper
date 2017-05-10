using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// A group of TestCases. For example, you can create 'Smoke Tests' TestPlan and add TestCases there.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestPlans/meta">API documentation - TestPlan</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class TestPlan : Assignable, IHasInitialEstimate, IHasRevisions, IHasTestCases,
        IHasTestPlanRuns, IHasRoleEfforts, IHasUserStories
    {
        [JsonProperty(Required = Required.Default)]
        public decimal CalculatedEstimate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public decimal InitialEstimate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Assignable LinkedAssignable { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Bug LinkedBug { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Build LinkedBuild { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Epic LinkedEpic { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Feature LinkedFeature { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public General LinkedGeneral { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Iteration LinkedIteration { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Release LinkedRelease { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Request LinkedRequest { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Task LinkedTask { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public TeamIteration LinkedTeamIteration { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public UserStory LinkedUserStory { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestCase> TestCases { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> ChildTestPlans { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> ParentTestPlans { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; internal set; }
    }
}