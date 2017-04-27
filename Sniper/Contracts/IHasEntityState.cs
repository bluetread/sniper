using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasEntityState
    {
        EntityState EntityState { get; set; }
    }
}