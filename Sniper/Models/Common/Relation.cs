using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Relation between two Entities.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Relations/meta">API documentation - Relation</a>
    /// </remarks>
    public class Relation : Entity
    {
        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public General Master { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public RelationType RelationType { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public General Slave { get; set; }
    }
}