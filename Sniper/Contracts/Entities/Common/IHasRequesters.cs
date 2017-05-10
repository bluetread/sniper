using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasRequesters
    {
        Collection<Requester> Requesters { get; }
    }
}