using System.Collections.Generic;

namespace Sniper.Contracts.Exceptions
{
    public interface IRequiredDataResponse
    {
        bool IsError { get; }
        ICollection<string> MissingPropertyNames { get; }
        IDictionary<string, ICollection<string>> MissingSubPropertyNames { get; }
    }
}
