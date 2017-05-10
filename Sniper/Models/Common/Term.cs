using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Beta version: Term in Process. Like Bug, User Story, Feature, etc.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Terms/meta">API documentation - Term</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Term : Entity, IHasProcess, IHasEntityType
    {
        [JsonProperty(Required = Required.Default)]
        public string WordKey { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string Value { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Process Process { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public EntityType EntityType { get; internal set; }
    }
}