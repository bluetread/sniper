using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTerms
    {
        Collection<Term> Terms { get; set; }
    }
}