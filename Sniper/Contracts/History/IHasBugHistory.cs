using System.Collections.ObjectModel;
using Sniper.History;

namespace Sniper.Contracts.History
{
    public interface IHasBugHistory
    {
        Collection<BugSimpleHistory> History { get; set; }
    }
}
