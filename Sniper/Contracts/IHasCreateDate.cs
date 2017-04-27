using System;

namespace Sniper.Contracts
{
    public interface IHasCreateDate
    {
        DateTime? CreateDate { get; set; }
    }
}
