using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// A set of steps to determine if a product functionality is working correctly. TestCase relates to User Story.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestCases/meta">API documentation - TestCase</a>
    /// </remarks>
    public class TestCase : General, IHasPriority, IHasTestPlans, IHasTestCaseRuns, IHasTestSteps, IHasUserStories
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string LastFailureComment { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? LastRunDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public TestCaseRunStatus LastRunStatus { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Priority Priority { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestCaseRun> TestCaseRun { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> TestPlan { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestStep> TestStep { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; set; }
    }
}