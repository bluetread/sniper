using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary></summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/AppContexts/meta">API documentation - AppContext</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class AppContext : Entity
    {
        public SimpleContext TeamContext { get; set; }
    }
}