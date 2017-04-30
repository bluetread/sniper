using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasReleases
    {
        Collection<Release> Releases { get; set; }
    }
}