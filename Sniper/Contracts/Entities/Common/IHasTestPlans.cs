using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestPlans
    {
        Collection<TestPlan> TestPlan { get; set; }
    }
}