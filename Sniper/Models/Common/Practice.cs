using System.Collections.ObjectModel;
using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// 
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Practices/meta">API documentation - Practice</a>
    /// </remarks>
    public class Practice : IHasId, IHasName, IHasDescription, IHasProcesses
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Collection<Process> Processes { get; set; }
    }
}
