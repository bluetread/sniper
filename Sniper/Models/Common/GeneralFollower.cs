using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Relation between user and following entity.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/GeneralFollowers/meta">API documentation - GeneralFollower</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class GeneralFollower : Entity, IHasGeneral, IHasUser
    {

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public General General { get; set; }

        [RequiredForCreate(JsonProperties.Email, JsonProperties.Login,
            JsonProperties.Password, JsonProperties.WeeklyAvailableHours)]
        [JsonProperty(Required = Required.DisallowNull)]
        public User User { get; set; }
    }
}