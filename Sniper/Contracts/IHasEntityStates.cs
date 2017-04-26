using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasEntityStates
    {
        Collection<EntityState> EntityStates { get; set; }
    }
}
