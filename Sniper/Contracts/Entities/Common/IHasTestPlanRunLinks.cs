using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestPlanRunLinks
    {
        Collection<TestRunItemHierarchyLink> TestPlanRunLinks { get; }
    }
}