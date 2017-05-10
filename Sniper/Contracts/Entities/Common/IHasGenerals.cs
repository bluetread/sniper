using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasGenerals
    {
        Collection<General> Generals { get; }
    }
}