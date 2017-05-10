using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestCaseRuns
    {
        Collection<TestCaseRun> TestCaseRun { get; }
    }
}