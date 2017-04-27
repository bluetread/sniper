using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasRequests
    {
        Collection<Request> Requests { get; set; }
    }
}