using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTasks
    {
        Collection<Task> Tasks{ get; set; }
    }
}
