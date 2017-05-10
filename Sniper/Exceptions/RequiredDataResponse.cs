using Sniper.Contracts.Exceptions;
using System.Collections.Generic;

namespace Sniper
{
    public class RequiredDataResponse : IRequiredDataResponse 
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public ICollection<string> MissingPropertyNames { get; set; } = new List<string>();
        public IDictionary<string, ICollection<string>> MissingSubPropertyNames { get; set; } 
            = new Dictionary<string, ICollection<string>>();
    }
}
