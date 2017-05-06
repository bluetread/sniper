using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestCaseRunLinks
    {
        Collection<TestRunItemHierarchyLink> TestCaseRunLinks { get; set; }
    }
}