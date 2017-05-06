using Sniper.Contracts.Entities.Common;

namespace Sniper.Common
{
    ///<summary>
    /// Custom field configuration.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/CustomRules/meta">API documentation - CustomRule</a>
    /// </remarks>
    public class CustomRule : Entity, IHasName, IHasDescription, IHasEnabled
    {
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
        public string Name { get; set; }
    }
}