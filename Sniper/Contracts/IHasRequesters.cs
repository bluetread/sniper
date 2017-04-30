using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasRequesters
    {
        Collection<Requester> Requesters { get; set; }
    }
}