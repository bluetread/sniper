using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sniper.Http
{
    public static class HttpProtocols
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpProtocol
        {
            [EnumMember(Value = Protocols.HypertextSecure)]
            HypertextSecure,
            [EnumMember(Value = Protocols.HypertextUnsecure)]
            HypertextUnsecure
        }

        private static readonly Collection<Tuple<HttpProtocol, string, int>> _httpProtocolInfo = new Collection<Tuple<HttpProtocol, string, int>>
        {
            new Tuple<HttpProtocol, string, int>(HttpProtocol.HypertextSecure, Protocols.HypertextSecure, Protocols.DefaultPortHypertextSecure),
            new Tuple<HttpProtocol, string, int>(HttpProtocol.HypertextUnsecure, Protocols.HypertextUnsecure, Protocols.DefaultPortHypertextUnsecure)
        };

        internal static ReadOnlyCollection<Tuple<HttpProtocol, string, int>> HttpProtocolInfo = new ReadOnlyCollection<Tuple<HttpProtocol, string, int>>(_httpProtocolInfo);
    }
}
