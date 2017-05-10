using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Priority of User Story, Bug or Feature. Examples: Must Have, Nice to Have.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Priorities/meta">API documentation - Priority</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Priority : Entity, IHasName, IHasEntityType
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.DisallowNull)]
        public EntityType EntityType { get; internal set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public int Importance { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsDefault { get; set; }
    }
}