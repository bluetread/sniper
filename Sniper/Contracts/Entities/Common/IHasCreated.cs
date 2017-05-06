using System;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasCreated
    {
        DateTime Created { get; set; }
    }
}