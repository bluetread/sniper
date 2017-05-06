using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasComments
    {
        Collection<Comment> Comments { get; set; }
    }
}