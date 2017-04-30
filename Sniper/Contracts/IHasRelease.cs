using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasRelease
    {
        Release Release { get; set; }
    }
}