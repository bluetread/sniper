using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// A single iteration results in an increment(s) of product functionality.
    /// Iteration should relate to a Release.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Iterations/meta">API documentation - Iteration</a>
    /// </remarks>
    public class Iteration : IterationBase, IHasRelease, IHasBuilds, IHasRequests
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override DateTime? EndDate { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override DateTime? StartDate { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Release Release { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public Collection<Build> Builds { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; set; }
    }
}