using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTestPlans
    {
        Collection<TestPlan> TestPlan { get; set; }
    }
}
