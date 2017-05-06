using System;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasDateRange
    {
        DateTime? EndDate { get; set; }
        DateTime? StartDate { get; set; }
    }
}