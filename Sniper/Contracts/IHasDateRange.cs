using System;

namespace Sniper.Contracts
{
    public interface IHasDateRange
    {
        DateTime? EndDate { get; set; }
        DateTime? StartDate { get; set; }
    }
}
