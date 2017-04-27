using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasTask
    {
        Task Task { get; set; }
    }
}