using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Culture which was selected in application. Affects date formats and decimal separator.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Cultures/meta">API documentation - Culture</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Culture : Entity, IHasName
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; internal set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string CurrencyDecimalDigits { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string CurrencyDecimalSeparator { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string CurrencyGroupSeparator { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string DecimalSeparator { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string LongDateFormat { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string ShortDateFormat { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string TimePattern { get; internal set; }
    }
}