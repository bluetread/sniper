using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasFollowers
    {
        Collection<GeneralFollower> Followers { get; set; }
    }
}
