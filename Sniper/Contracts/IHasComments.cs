using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasComments
    {
        Collection<Comment> Comments { get; set; }
    }
}
