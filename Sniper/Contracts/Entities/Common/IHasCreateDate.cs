using System;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasCreateDate
    {
        DateTime? CreateDate { get; set; }
    }
}