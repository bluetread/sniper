using Newtonsoft.Json;

namespace Sniper.Common
{
    public class SimpleContext : Entity
    {
        [JsonProperty(Required = Required.Default)]
        public bool No { get; set; }
    }
}