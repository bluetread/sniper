using System;

namespace Sniper.Contracts
{
    public interface IHasEffectiveDates
    {
        DateTime? EffectiveEndDate { get; set; }
        DateTime? EffectiveStartDate { get; set; }
    }
}
