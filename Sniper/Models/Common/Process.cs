using Sniper.Contracts;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    /// <summary>
    /// Set of practices, terms, workflows and custom fields that can be applied to Project.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Processes/meta">API documentation - Process</a>
    /// </remarks>
    public class Process : IHasId, IHasName, IHasDescription, IHasProjects,
        IHasPractices, IHasCustomFields, IHasProcessAdmins, IHasTerms, IHasWorkFlows
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public Collection<CustomField> CustomFields { get; set; }
        public Collection<Practice> Practices { get; set; }
        public Collection<User> ProcessAdmins { get; set; }
        public Collection<Project> Projects { get; set; }
        public Collection<Term> Terms { get; set; }
        public Collection<Workflow> Workflows { get; set; }
    }
}