using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestStepRuns
    {
        Collection<TestStepRun> TestStepRuns { get; set; }
    }
}