using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTestPlanRuns
    {
        Collection<TestPlanRun> TestPlanRuns { get; set; }
    }
}