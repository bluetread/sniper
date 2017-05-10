using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasRevisions
    {
        Collection<Revision> Revisions { get; }
    }
}