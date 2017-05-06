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
    [CannotCreateReadUpdateDelete]
    public class GeneralUser : Entity, IHasActive, IHasCreateDate, IHasModifyDate,
        IHasCustomFields, IHasAssignables, IHasComments, IHasRequests
    {
        public DateTime? CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public virtual string Email { get; set; }
        public virtual string FirstName { get; set; }
        public string GlobalId { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdministrator { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Login { get; set; }
        public DateTime? ModifyDate { get; set; }
        public virtual string Password { get; set; }

        public Uri AvatarUrl { get; set; }
        public UserEntityKind Kind { get; set; }

        public Collection<Assignable> Assignables { get; set; }
        public Collection<CustomField> CustomFields { get; set; }
        public Collection<Comment> Comments { get; set; }
        public Collection<Request> Requests { get; set; }
    }
}