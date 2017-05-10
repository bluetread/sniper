using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasIterations
    {
        Collection<Iteration> Iterations { get; }
    }
}