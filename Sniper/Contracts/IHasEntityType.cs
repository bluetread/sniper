using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasEntityType
    {
        EntityType EntityType { get; set; }
    }
}