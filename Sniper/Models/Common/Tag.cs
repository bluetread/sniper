using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Tags that can be attached to entities.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Tags/meta">API documentation - Tag</a>
    /// </remarks>
    public class Tag : Entity, IHasName, IHasGenerals
    {
        public string Name { get; set; }

        public Collection<General> Generals { get; set; }
    }
}