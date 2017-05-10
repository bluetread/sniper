using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// A single Test Step Run
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestStepRuns/meta">API documentation - TestStepRun</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class TestStepRun : Entity, IHasDescription, IHasTestCaseRun, IHasTestStep
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.TestPlanRun, JsonProperties.RootTestPlanRun)]
        [JsonProperty(Required = Required.DisallowNull)]
        public TestCaseRun TestCaseRun { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool Passed { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Result { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool Runned { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int RunOrder { get; set; }

        [JsonProperty(Required = Required.Default)]
        public TestStep TestStep { get; set; }
    }
}