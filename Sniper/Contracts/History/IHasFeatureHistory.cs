using System.Collections.ObjectModel;
using Sniper.History;

namespace Sniper.Contracts.History
{
    public interface IHasFeatureHistory
    {
        Collection<FeatureSimpleHistory> History { get; set; }
    }
}
