using System.Collections.ObjectModel;
using Sniper.History;

namespace Sniper.Contracts.History
{
    public interface IHasTaskHistory
    {
        Collection<TaskSimpleHistory> History { get; set; }
    }
}
