using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.History
{
    public interface IHasUserHistory
    {

        Collection<UserStorySimpleHistory> History { get; set; }
    }
}
