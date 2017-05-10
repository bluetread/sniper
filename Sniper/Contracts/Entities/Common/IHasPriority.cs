using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasPriority
    {
        Priority Priority { get; set; }
    }
}