using System;
using Newtonsoft.Json;
using Sniper.Application;

namespace Sniper.Contracts
{
    public interface IHasDate
    {
        [JsonProperty(JsonProperties.Date)]
        DateTime? EntryDate { get; set; }
    }
}
