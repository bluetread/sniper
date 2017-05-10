using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasRelations
    {
        Collection<Relation> Relations { get; }
    }
}