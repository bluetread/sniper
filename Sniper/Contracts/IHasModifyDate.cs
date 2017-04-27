using System;

namespace Sniper.Contracts
{
    public interface IHasModifyDate
    {
        DateTime? ModifyDate { get; set; }
    }
}