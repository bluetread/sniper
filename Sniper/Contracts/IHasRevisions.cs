using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasRevisions
    {
        Collection<Revision> Revisions { get; set; }
    }
}