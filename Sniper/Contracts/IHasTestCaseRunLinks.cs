using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasTestCaseRunLinks
    {
        Collection<TestRunItemHierarchyLink> TestCaseRunLinks { get; set; }
    }
}
