using System;

namespace Sniper.Contracts
{
    public interface IHasPlannedDates
    {
        DateTime? PlannedEndDate { get; set; }
        DateTime? PlannedStartDate { get; set; }
    }
}
