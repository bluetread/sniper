using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasFeatures
    {
        Collection<Feature> Features { get; set; }
    }
}
