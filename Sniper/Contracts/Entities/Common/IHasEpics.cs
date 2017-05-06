using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasEpics
    {
        Collection<Epic> Epics { get; set; }
    }
}