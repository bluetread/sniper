using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
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
        public DateTime? CreateDate { get; set; }
        public int? ParentId { get; set; }

        #region Required for Create

        [RequiredForCreate]
        public string Description { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public General General { get; set; }

        #endregion

        public GeneralUser Owner { get; set; }
    }
}