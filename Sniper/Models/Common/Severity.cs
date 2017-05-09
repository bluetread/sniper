using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Severity (badness) of Bug. For example, Blocking, Critical, Small.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Severities/meta">API documentation - Severity</a>
    /// </remarks>
    public class Severity : Entity, IHasName
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public int Importance { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsDefault { get; set; }

    }
}