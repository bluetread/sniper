﻿using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;

namespace Sniper.Common
{
    /// <summary>
    /// Outbound relation for Assignable.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/OutboundAssignables/meta">API documentation - OutboundAssignable</a>
    /// </remarks>
    public class OutboundAssignable : Assignable, IHasRelationType
    {
        [JsonProperty(Required = Required.Default)]
        public General InboundGeneral { get; set; }

        [JsonProperty(Required = Required.Default)]
        public RelationType RelationType { get; set; }
    }
}