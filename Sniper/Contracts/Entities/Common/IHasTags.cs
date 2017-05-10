using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTags
    {
        Collection<Tag> TagObjects { get; }
    }
}