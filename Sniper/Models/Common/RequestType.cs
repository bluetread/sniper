using System.Collections.ObjectModel;
using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// Type of request (Idea, Issue or Question).
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RequestTypes/meta">API documentation - RequestType</a>
    /// </remarks>
    public class RequestType :IHasId, IHasName, IHasRequests
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }

        public Collection<Request> Requests { get; set; }
    }
}
