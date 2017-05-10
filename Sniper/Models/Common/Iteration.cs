using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
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
    [CanCreateReadUpdateDelete]
    public class Iteration : IterationBase, IHasRelease, IHasBuilds, IHasRequests
    {
        #region Required for Create
     
        [RequiredForCreate(JsonProperties.Name, JsonProperties.StartDate, JsonProperties.EndDate)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Release Release { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public Collection<Build> Builds { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; internal set; }
    }
}