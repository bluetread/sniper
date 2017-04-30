using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasEpics
    {
        Collection<Epic> Epics { get; set; }
    }
}
