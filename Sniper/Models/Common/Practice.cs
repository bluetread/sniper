using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    ///
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Practices/meta">API documentation - Practice</a>
    /// </remarks>
    public class Practice : Entity, IHasName, IHasDescription, IHasProcesses
    {
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Collection<Process> Processes { get; set; }
    }
}