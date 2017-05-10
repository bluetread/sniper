using System;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasModifyDate
    {
        DateTime? ModifyDate { get; set; }
    }
}