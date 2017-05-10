using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    [CanCreateReadUpdateDelete]
    public class SimpleContext : Entity
    {
        [JsonProperty(Required = Required.Default)]
        public bool No { get; set; }
    }
}