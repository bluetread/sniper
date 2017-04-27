using System.Runtime.Serialization;

namespace Sniper.Http
{
    public static class HttpResponseFormats
    {
        public enum ResponseFormat
        {
            [EnumMember(Value = ResponseFormatKeys.None)]
            None,

            [EnumMember(Value = ResponseFormatKeys.Json)]
            Json,

            [EnumMember(Value = ResponseFormatKeys.Xml)]
            Xml,

            Default = Xml
        }
    }
}