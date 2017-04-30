using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTestSteps
    {
        Collection<TestStep> TestStep { get; set; }
    }
}
