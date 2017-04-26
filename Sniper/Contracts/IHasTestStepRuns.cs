using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasTestStepRuns
    {
        Collection<TestStepRun> TestStepRuns { get; set; }
    }
}
