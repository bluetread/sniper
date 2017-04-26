using System.Collections.ObjectModel;
using Sniper.Contracts;

namespace Sniper.Common
{
    /// <summary>
    /// Context contains information about logged User, Culture, selected Projects and Processes.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Context/meta">API documentation - Context</a>
    /// </remarks>
    public class Context : IHasId, IHasCustomFields
    {
        public int Id { get; set; }
        public string Acid { get; set; }
        public bool AnyProject { get; set; }
        public bool AnyTeam { get; set; }
        public string Edition { get; set; }
        public bool IsFull { get; set; }
        public bool IsNoTeamIncluded { get; set; }
        public string Version { get; set; }

        public AppContext AppContext { get; set; }
        public Culture Culture { get; set; }
        public User LoggedUser { get; set; }

        public Collection<CustomField> CustomFields { get; set; }
    }
}
