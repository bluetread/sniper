using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasEntityType
    {
        EntityType EntityType { get; set; }
    }
}