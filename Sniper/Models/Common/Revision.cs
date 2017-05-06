using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// A single commit into repository. Contains a set of source files.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Revisions/meta">API documentation - Revision</a>
    /// </remarks>
    public class Revision : Entity, IHasDescription, IHasProject, IHasRevisionFiles, IHasAssignables
    {
        public DateTime CommitDate { get; set; }
        public string Description { get; set; }

        #region Required for Create

        [RequiredForCreate]
        public string SourceControlId { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public Project Project { get; set; }

        #endregion

        public User Author { get; set; }
        
        public Collection<Assignable> Assignables { get; set; }
        public Collection<RevisionFile> RevisionFiles { get; set; }
    }
}