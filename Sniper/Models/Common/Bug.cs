using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using Sniper.Contracts.Entities.History;
using Sniper.History;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Bug or defect (error, flaw, mistake, failure or fault in a computer program). Can relate to User Story. Can be assigned to Release and Iteration.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Bugs/meta">API documentation - Bug</a>
    /// </remarks>
    public class Bug : Assignable, IHasBuild, IHasFeature, IHasSeverity, IHasUserStory,
        IHasBugHistory, IHasTestCaseRuns, IHasTestPlanRuns
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }
        
        ////TODO: double-check this
        //[RequiredForCreate(JsonProperties.Id)]
        //public override EntityState EntityState { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public Build Build { get; set; }
        
        [JsonProperty(Required = Required.Default)]
        public Feature Feature { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Severity Severity { get; set; }

        [JsonProperty(Required = Required.Default)]
        public UserStory UserStory { get; set; }
        
        [JsonProperty(Required = Required.Default)]
        public Collection<BugSimpleHistory> History { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestCaseRun> TestCaseRun { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
    }
}