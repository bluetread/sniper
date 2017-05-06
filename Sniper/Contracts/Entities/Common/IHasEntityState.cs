using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasEntityState
    {
        EntityState EntityState { get; set; }
    }
}