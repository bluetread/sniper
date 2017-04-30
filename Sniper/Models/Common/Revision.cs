using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// A single commit into repository. Contains a set of source files.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Revisions/meta">API documentation - Revision</a>
    /// </remarks>
    public class Revision : IHasId, IHasDescription, IHasProject, IHasRevisionFiles, IHasAssignables
    {
        public int Id { get; set; }
        public DateTime CommitDate { get; set; }
        public string Description { get; set; }
        public string SourceControlId { get; set; }

        public User Author { get; set; }
        public Project Project { get; set; }

        public Collection<Assignable> Assignables { get; set; }
        public Collection<RevisionFile> RevisionFiles { get; set; }
    }
}