using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasTestPlanRuns
    {
        Collection<TestPlanRun> TestPlanRuns { get; set; }
    }
}
