using Newtonsoft.Json;
using Sniper.Application;
using System;

namespace Sniper.Contracts
{
    public interface IHasDate
    {
        [JsonProperty(JsonProperties.Date)]
        DateTime? EntryDate { get; set; }
    }
}