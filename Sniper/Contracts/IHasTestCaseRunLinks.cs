using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTestCaseRunLinks
    {
        Collection<TestRunItemHierarchyLink> TestCaseRunLinks { get; set; }
    }
}