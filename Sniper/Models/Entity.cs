using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;

namespace Sniper
{
    [JsonObject(ItemRequired = Required.Always)]
    public abstract class Entity : IHasId, IHasResourceType
    {
        public virtual int Id { get; set; }

        [JsonIgnore, JsonProperty(Required = Required.Default)]
        public virtual string ResourceType { get; private set; }
    }
}
