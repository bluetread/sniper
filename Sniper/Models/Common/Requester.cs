using Sniper.Contracts;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// Represents a requester.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Requesters/meta">API documentation - Requester</a>
    /// </remarks>
    public class Requester : GeneralUser, IHasCompany
    {
        public string Notes { get; set; }
        public string Phone { get; set; }

        public RequesterSourceType SourceType { get; set; }

        public Company Company { get; set; }
    }
}