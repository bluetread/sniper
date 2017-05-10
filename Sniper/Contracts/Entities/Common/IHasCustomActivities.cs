using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasCustomActivities
    {
        Collection<CustomActivity> CustomActivities { get; }
    }
}