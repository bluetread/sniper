using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// A single Test Case Run. TestCase can be run many times.
    /// It is impossible to create a Test Case Run, instead Add Test Case to Test Plan to create a Test Case Run
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestCaseRuns/meta">API documentation - TestCaseRun</a>
    /// </remarks>
    public class TestCaseRun : Entity, IHasName, IHasDescription, IHasTestPlanRun, IHasTestCase,
        IHasEntityType, IHasPriority, IHasTestStepRuns, IHasBugs, IHasTestPlanRunLinks
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public TestPlanRun TestPlanRun { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public TestPlanRun RootTestPlanRun { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string Comment { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime EndRunDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime StartRunDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public TestCaseRunStatus Status { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Steps { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Success { get; set; }

        [JsonProperty(Required = Required.Default)]
        public EntityType EntityType { get; set; }

        [JsonProperty(Required = Required.Default)]
        public User LastExecutor { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Priority Priority { get; set; }

        [JsonProperty(Required = Required.Default)]
        public TestCase TestCase { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestStepRun> TestStepRuns { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestRunItemHierarchyLink> TestPlanRunLinks { get; set; }
    }
}