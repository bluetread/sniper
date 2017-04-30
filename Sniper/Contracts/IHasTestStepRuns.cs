using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTestStepRuns
    {
        Collection<TestStepRun> TestStepRuns { get; set; }
    }
}