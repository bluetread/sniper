using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTestCases
    {
        Collection<TestCase> TestCases { get; set; }
    }
}