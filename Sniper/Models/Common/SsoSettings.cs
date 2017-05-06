using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    /// <summary>
    /// Single sign-on Application Settings.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/SsoSettings/meta">API documentation - SsoSettings</a>
    /// </remarks>
    public class SsoSettings : IHasEnabled
    {
        public string Certificate { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsFormAuthenticationDisabled { get; set; }
        public bool IsUserProvisioningEnabled { get; set; }
        public string SignonUrl { get; set; }

        public Collection<User> ExceptionUsers { get; set; }
    }
}