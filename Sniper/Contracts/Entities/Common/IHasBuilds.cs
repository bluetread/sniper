using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasBuilds
    {
        Collection<Build> Builds { get; }
    }
}