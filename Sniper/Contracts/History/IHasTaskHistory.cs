using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.History
{
    public interface IHasTaskHistory
    {
        Collection<TaskSimpleHistory> History { get; set; }
    }
}
