using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTags
    {
        Collection<Tag> TagObjects { get; set; }
    }
}