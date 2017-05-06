using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTerms
    {
        Collection<Term> Terms { get; set; }
    }
}