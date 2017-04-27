using Sniper.Contracts;
using System;

namespace Sniper.Common
{
    ///<summary>
    /// Can be added to almost any Entity.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Comments/meta">API documentation - Comment</a>
    /// </remarks>
    public class Comment : IHasId, IHasDescription, IHasCreateDate, IHasGeneral, IHasOwner
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }

        public General General { get; set; }
        public GeneralUser Owner { get; set; }
    }
}
