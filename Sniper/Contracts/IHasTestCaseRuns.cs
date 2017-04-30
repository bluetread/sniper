using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTestCaseRuns
    {
        Collection<TestCaseRun> TestCaseRun { get; set; }
    }
}