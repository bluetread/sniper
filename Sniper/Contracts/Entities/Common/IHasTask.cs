using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTask
    {
        Task Task { get; set; }
    }
}