using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Set of practices, terms, workflows and custom fields that can be applied to Project.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Processes/meta">API documentation - Process</a>
    /// </remarks>
    public class Process : Entity, IHasName, IHasDescription, IHasProjects,
        IHasPractices, IHasCustomFields, IHasProcessAdmins, IHasTerms, IHasWorkFlows
    {
        public string Description { get; set; }

        #region Required for Create

        [RequiredForCreate]
        public string Name { get; set; }

        #endregion

        public Collection<CustomField> CustomFields { get; set; }
        public Collection<Practice> Practices { get; set; }
        public Collection<User> ProcessAdmins { get; set; }
        public Collection<Project> Projects { get; set; }
        public Collection<Term> Terms { get; set; }
        public Collection<Workflow> Workflows { get; set; }
    }
}