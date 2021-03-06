﻿using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// Type of Entity. For example: Bug, TestCase, Project.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/EntityTypes/meta">API documentation - EntityType</a>
    /// </remarks>
    [CannotCreateReadUpdateDelete]
    public class EntityType : Entity, IHasName, IAssignable, IExtendable
    {
        [JsonProperty(Required = Required.Default)]
        public virtual CustomFieldScope CustomFieldScope { get; internal set; } = CustomFieldScope.None;

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsAssignable { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsExtendable { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsSearchable { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsUnitInHourOnly { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual string Name { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<EntityState> EntityStates { get; internal set; }
    }
}