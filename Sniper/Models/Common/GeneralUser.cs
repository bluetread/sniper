using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// Base entity for User and Requester.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/GeneralUsers/meta">API documentation - GeneralUser</a>
    /// </remarks>
    public class GeneralUser : IHasId, IHasActive, IHasCreateDate, IHasModifyDate, 
        IHasCustomFields, IHasAssignables, IHasComments, IHasRequests
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string GlobalId { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdministrator { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Password { get; set; }

        public Uri AvatarUrl { get; set; }
        public UserEntityKind Kind { get; set; }

        public Collection<Assignable> Assignables { get; set; }
        public Collection<CustomField> CustomFields { get; set; }
        public Collection<Comment> Comments { get; set; }
        public Collection<Request> Requests { get; set; }
    }
}
