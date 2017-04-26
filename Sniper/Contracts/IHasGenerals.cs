using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasGenerals
    {
        Collection<General> Generals { get; set; }
    }
}
