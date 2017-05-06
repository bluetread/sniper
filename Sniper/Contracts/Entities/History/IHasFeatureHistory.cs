using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.History
{
    public interface IHasFeatureHistory
    {
        Collection<FeatureSimpleHistory> History { get; set; }
    }
}