using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;

namespace Sniper.Common
{
    /// <summary>
    /// Culture which was selected in application. Affects date formats and decimal separator.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Cultures/meta">API documentation - Culture</a>
    /// </remarks>
    public class Culture : Entity, IHasName
    {
        [JsonProperty(Required = Required.Default)]
        public string CurrencyDecimalDigits { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string CurrencyDecimalSeparator { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string CurrencyGroupSeparator { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string DecimalSeparator { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string LongDateFormat { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string ShortDateFormat { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string TimePattern { get; set; }
    }
}