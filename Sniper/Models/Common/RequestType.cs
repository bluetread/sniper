using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Type of request (Idea, Issue or Question).
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RequestTypes/meta">API documentation - RequestType</a>
    /// </remarks>
    [CannotCreateReadUpdateDelete]
    public class RequestType : Entity, IHasName, IHasRequests
    {
        public string Icon { get; set; }
        public string Name { get; set; }

        public Collection<Request> Requests { get; set; }
    }
}