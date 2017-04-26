using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasRelations
    {
        Collection<Relation> Relations { get; set; }
    }
}
