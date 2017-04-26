using Sniper.Contracts;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// 
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Programs/meta">API documentation - Program</a>
    /// </remarks>
    public class Program : General, IHasProjects
    {
        public Collection<Project> Projects { get; set; }
    }
}
