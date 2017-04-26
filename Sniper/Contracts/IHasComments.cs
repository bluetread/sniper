using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasComments
    {
        Collection<Comment> Comments { get; set; }
    }
}
