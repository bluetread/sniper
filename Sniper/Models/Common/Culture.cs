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
        public string CurrencyDecimalDigits { get; set; }
        public string CurrencyDecimalSeparator { get; set; }
        public string CurrencyGroupSeparator { get; set; }
        public string DecimalSeparator { get; set; }
        public string LongDateFormat { get; set; }
        public string Name { get; set; }
        public string ShortDateFormat { get; set; }
        public string TimePattern { get; set; }
    }
}