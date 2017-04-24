using System.Globalization;
using Sniper.WarningsErrors;

namespace Sniper.Http
{
    public class SiteInfo : ISiteInfo
    {
        public string BaseUrl { get; set; }
        public string HostName { get; set; }
        public bool IsApiIncluded { get; set; } //include "/api" in route
        public bool IsJsonFormat { get; set; } // True = JSON, False = XML (default)
        public bool IsVersionIncluded { get; set; } //include version number "/1"
        public bool IsVersionLetterIncluded { get; set; } //include "v", as in "/v1" or "/v2" instead of "/1"
        public int Port { get; set; }
        public int Version { get; set; }

        //TODO: add port if not default
        [System.Diagnostics.CodeAnalysis.SuppressMessage(MessageSuppression.Categories.Globalization, MessageSuppression.MessageAttributes.SpecifyIFormatProvider)]
        public string ApiUrl => $@"{Protocols.HypertextSecure}://{HostName}.{BaseUrl}{(IsApiIncluded ?
            "/api" : string.Empty)}/{(IsVersionLetterIncluded ? "v" : string.Empty)}{(IsVersionIncluded ? Version.ToString(CultureInfo.CurrentCulture) : string.Empty)}";
    }
}
