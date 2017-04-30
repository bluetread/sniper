using System;

namespace Sniper.Contracts
{
    public interface IHasForecastEndDate
    {
        DateTime? ForecastEndDate { get; set; }
    }
}
