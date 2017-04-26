using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTestPlanRunLinks
    {
        Collection<TestRunItemHierarchyLink> TestPlanRunLinks { get; set; }
    }
}
