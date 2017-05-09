using Newtonsoft.Json;
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
        [JsonProperty(Required = Required.Default)]
        public string Certificate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsEnabled { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsFormAuthenticationDisabled { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsUserProvisioningEnabled { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string SignonUrl { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<User> ExceptionUsers { get; set; }
    }
}