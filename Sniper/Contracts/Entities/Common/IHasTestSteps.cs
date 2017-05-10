using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestSteps
    {
        Collection<TestStep> TestStep { get; set; }
    }
}