using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.History
{
    public interface IHasBugHistory
    {
        Collection<BugSimpleHistory> History { get; set; }
    }
}
