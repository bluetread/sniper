using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Build in a project. Bugs and source code Revisions can be assigned to Build.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Builds/meta">API documentation - Build</a>
    /// </remarks>
    public class Build : General, IHasBugs, IHasTestPlanRuns
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
        public DateTime BuildDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Iteration Iteration { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Release Release { get; set; }


        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
    }
}