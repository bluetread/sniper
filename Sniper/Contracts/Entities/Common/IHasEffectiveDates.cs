using System;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasEffectiveDates
    {
        DateTime? EffectiveEndDate { get; }
        DateTime? EffectiveStartDate { get; }
    }
}