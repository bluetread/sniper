using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasIterations
    {
        Collection<Iteration> Iterations { get; set; }
    }
}