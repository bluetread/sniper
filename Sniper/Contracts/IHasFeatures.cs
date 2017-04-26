using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasFeatures
    {
        Collection<Feature> Features { get; set; }
    }
}
