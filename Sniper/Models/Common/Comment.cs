using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Can be added to almost any Entity.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Comments/meta">API documentation - Comment</a>
    /// </remarks>
    public class Comment : Entity, IHasDescription, IHasCreateDate, IHasGeneral, IHasOwner
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Description { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public General General { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime? CreateDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int? ParentId { get; set; }

        [JsonProperty(Required = Required.Default)]
        public GeneralUser Owner { get; set; }
    }
}