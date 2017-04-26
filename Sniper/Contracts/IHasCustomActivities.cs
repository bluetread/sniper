using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasCustomActivities
    {
        Collection<CustomActivity> CustomActivities { get; set; }
    }
}
