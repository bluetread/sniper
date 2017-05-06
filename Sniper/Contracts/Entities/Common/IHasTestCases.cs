using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestCases
    {
        Collection<TestCase> TestCases { get; set; }
    }
}