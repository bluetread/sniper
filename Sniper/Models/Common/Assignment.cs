using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// An assignment of the User Story, Task, Bug, etc. with a specific Role and user.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Assignments/meta">API documentation - Assignment</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Assignment : Entity, IHasAssignable, IHasRole
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.EntityState, JsonProperties.Priority)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Assignable Assignable { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Role Role { get; set; }

        [RequiredForCreate(JsonProperties.Email, JsonProperties.Login,
            JsonProperties.Password, JsonProperties.WeeklyAvailableHours)]
        [JsonProperty(Required = Required.DisallowNull)]
        public User GeneralUser { get; set; }

        #endregion

    }
}