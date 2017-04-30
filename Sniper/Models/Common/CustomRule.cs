using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// Custom field configuration.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/CustomRules/meta">API documentation - CustomRule</a>
    /// </remarks>
    public class CustomRule : IHasId, IHasName, IHasDescription, IHasEnabled
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
        public string Name { get; set; }
    }
}
