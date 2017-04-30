using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary></summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/AppContexts/meta">API documentation - AppContext</a>
    /// </remarks>
    public class AppContext : IHasId
    {
        public int Id { get; set; }
        private SimpleContext TeamContext { get; set; }
    }
}