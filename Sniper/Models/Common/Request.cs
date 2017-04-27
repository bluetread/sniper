using Sniper.Contracts.History;
using Sniper.History;
using System.Collections.ObjectModel;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// Request can represent Idea, Issue or Question from users. Bugs, User Stories and Features can be linked to Requests.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Requests/meta">API documentation - Request</a>
    /// </remarks>
    public class Request : Assignable, IHasRequestHistory
    {
        public bool IsPrivate { get; set; }
        public bool IsReplied { get; set; }
        public int VotesCount { get; set; }

        public RequestSource SourceType { get; set; }
        public RequestType RequestType { get; set; }

        public Collection<GeneralUser> Requesters { get; set; }
        public Collection<RequestSimpleHistory> History { get; set; }
    }
}