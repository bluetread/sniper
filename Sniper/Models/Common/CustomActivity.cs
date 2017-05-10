using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Special type of work you can track Time against.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/CustomActivities/meta">API documentation - CustomActivity</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class CustomActivity : Entity, IHasName, IHasCreated, IHasEstimate, IHasProject, IHasTimes, IHasUser
    {
        [JsonProperty(Required = Required.Default)]
        public DateTime Created { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Estimate { get; set; }

        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Project Project { get; set; }

        #endregion

        [RequiredForCreate(JsonProperties.Email, JsonProperties.Login,
            JsonProperties.Password, JsonProperties.WeeklyAvailableHours)]
        [JsonProperty(Required = Required.Default)]
        public User User { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Time> Times { get; internal set; }
    }
}