﻿using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Inbound relation for Assignable.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/InboundAssignables/meta">API documentation - InboundAssignable</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class InboundAssignable : Assignable, IHasRelationType
    {
        [JsonProperty(Required = Required.Default)]
        public General OutboundGeneral { get; set; }

        [JsonProperty(Required = Required.Default)]
        public RelationType RelationType { get; set; }
    }
}