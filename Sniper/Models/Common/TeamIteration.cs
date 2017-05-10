using Sniper.Application;
using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// A single iteration results in an increment(s) of product functionality.
    /// Team iteration should relate to a Team.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TeamIterations/meta">API documentation - TeamIteration</a>
    /// </remarks>
    public class TeamIteration : IterationBase
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Team Team { get; set; }

        #endregion
    }
}