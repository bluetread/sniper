using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasRequesters
    {
        Collection<Requester> Requesters { get; set; }
    }
}
