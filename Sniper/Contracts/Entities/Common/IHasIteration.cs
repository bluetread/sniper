using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasIteration
    {
        Iteration Iteration { get; set; }
    }
}