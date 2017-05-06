using System;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasForecastEndDate
    {
        DateTime? ForecastEndDate { get; set; }
    }
}