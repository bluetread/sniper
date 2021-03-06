﻿using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using Sniper.Contracts.Entities.History;
using Sniper.History;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// A high-level scope of work which contains Features.
    /// Can be assigned to Release. Can't be assigned to Iteration.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Epics/meta">API documentation - Epic</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Epic : Assignable, IHasInitialEstimate, IHasFeatures, IHasEpicHistory
    {
        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal InitialEstimate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Feature> Features { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<EpicSimpleHistory> History { get; internal set; }
    }
}