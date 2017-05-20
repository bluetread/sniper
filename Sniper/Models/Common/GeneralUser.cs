using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// Base entity for User and Requester.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/GeneralUsers/meta">API documentation - GeneralUser</a>
    /// </remarks>
    [CanCreateReadUpdateDelete(CanCreate = false)]
    public class GeneralUser : Entity, IHasActive, IHasCreateDate, IHasModifyDate,
        IHasCustomFields, IHasAssignables, IHasComments, IHasRequests
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public virtual string Email { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public virtual string Login { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public virtual string Password { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime? CreateDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? DeleteDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual string FirstName { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string GlobalId { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsActive { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsAdministrator { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual string LastName { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? ModifyDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Uri AvatarUrl { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public UserEntityKind Kind { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<CustomField> CustomFields { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Comment> Comments { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; internal set; }
    }
}