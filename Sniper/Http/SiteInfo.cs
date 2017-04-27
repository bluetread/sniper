using System.Linq;
using System.Text;
using static Sniper.Http.HttpProtocols;
using static Sniper.Http.HttpResponseFormats;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.Http
{
    public class SiteInfo : ISiteInfo
    {
        public string BaseUrl { get; set; }
        public ResponseFormat DefaultResponseFormat { get; set; }  = ResponseFormat.Default;
        public string HostName { get; set; }

        public bool IsApiIncluded { get; set; } //include "/api" in route

        //public bool IsJsonFormat { get; set; } // True = JSON, False = XML (default)
        public bool IsVersionIncluded { get; set; } //include version number "/1"

        public bool IsVersionLetterIncluded { get; set; } //include "v", as in "/v1" or "/v2" instead of "/1"
        public int Port { get; set; }
        public HttpProtocol Protocol { get; set; } = HttpProtocol.HypertextSecure;
        public int Version { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider)]
        public string ApiUrl => $@"{GetProtocolParameter()}://{HostName}.{BaseUrl}{GetPortParameter()}{GetApiBase()}";

        private string GetApiBase()
        {
            var sb = new StringBuilder();

            if (IsApiIncluded)
                sb.Append("/api");

            if (IsVersionIncluded)
            {
                sb.Append(@"/");

                if (IsVersionLetterIncluded)
                    sb.Append("v");

                sb.Append(Version);
            }
            return sb.ToString();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage(Categories.Globalization, MessageAttributes.UseOrdinalStringComparison)]
        private string GetPortParameter()
        {
            if (Port == 0 || 
                (Protocol == HttpProtocol.HypertextSecure && Port == Protocols.DefaultPortHypertextSecure) ||
                (Protocol == HttpProtocol.HypertextUnsecure && Port == Protocols.DefaultPortHypertextUnsecure))
                return string.Empty;

            return $":{Port}";
        }

        private string GetProtocolParameter()
        {
            var protocolData = HttpProtocolInfo.FirstOrDefault(λ => λ.Item1 == Protocol);
            return (protocolData?.Item2 ?? Protocols.HypertextSecure).ToLowerCase();
        }
    }
}
