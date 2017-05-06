using System;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasEffectiveDates
    {
        DateTime? EffectiveEndDate { get; set; }
        DateTime? EffectiveStartDate { get; set; }
    }
}