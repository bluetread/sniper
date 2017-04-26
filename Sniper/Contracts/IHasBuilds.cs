using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasBuilds
    {
        Collection<Build> Builds { get; set; }
    }
}
