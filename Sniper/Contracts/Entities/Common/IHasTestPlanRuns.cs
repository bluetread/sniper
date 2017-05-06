using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestPlanRuns
    {
        Collection<TestPlanRun> TestPlanRuns { get; set; }
    }
}