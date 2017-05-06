using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;

namespace Sniper
{
    [JsonObject(ItemRequired = Required.Always)]
    public abstract class Entity : IHasId, IHasResourceType
    {
        public int Id { get; set; }

        [JsonIgnore, JsonProperty(Required = Required.Default)]
        public string ResourceType { get; private set; }
    }
}
