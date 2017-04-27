using Sniper.Contracts;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Used to limit Requests visibility in Help Desk. Requesters from Company A will not see Requests from Company B.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Companies/meta">API documentation - Company</a>
    /// </remarks>
    public class Company : IHasId, IHasDescription, IHasName, IHasUrl, IHasProjects, IHasRequesters
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public Collection<Project> Projects { get; set; }
        public Collection<Requester> Requesters { get; set; }
    }
}
