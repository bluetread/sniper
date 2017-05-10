using System;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasPlannedDates
    {
        DateTime? PlannedEndDate { get; set; }
        DateTime? PlannedStartDate { get; set; }
    }
}