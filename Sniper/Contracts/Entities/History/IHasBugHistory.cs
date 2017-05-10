using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.History
{
    public interface IHasBugHistory
    {
        Collection<BugSimpleHistory> History { get; set; }
    }
}