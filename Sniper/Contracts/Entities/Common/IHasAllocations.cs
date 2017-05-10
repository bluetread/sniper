using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasAllocations
    {
        Collection<ProjectAllocation> Allocations { get; }
    }
}