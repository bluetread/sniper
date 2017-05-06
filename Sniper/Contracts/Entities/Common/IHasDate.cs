using Newtonsoft.Json;
using Sniper.Application;
using System;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasDate
    {
        [JsonProperty(JsonProperties.Date)]
        DateTime? EntryDate { get; set; }
    }
}