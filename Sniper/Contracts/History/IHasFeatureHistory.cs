using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.History
{
    public interface IHasFeatureHistory
    {
        Collection<FeatureSimpleHistory> History { get; set; }
    }
}
