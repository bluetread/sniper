using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Custom field configuration.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/CustomRules/meta">API documentation - CustomRule</a>
    /// </remarks>
    [CanRead, CanUpdate]
    public class CustomRule : Entity, IHasName, IHasDescription, IHasEnabled
    {
        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsEnabled { get; set; }
    }
}