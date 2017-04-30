using System;

namespace Sniper.Contracts
{
    public interface IHasLastStateChangeDate
    {
        DateTime? LastStateChangeDate { get; set; }
    }
}