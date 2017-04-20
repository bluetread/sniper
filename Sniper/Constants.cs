namespace Sniper.ApiClients
{
    public static class ApiClientKeys
    {
        public const string Connection = "apiConnection";
        public const string Options = "options";
    }
}

namespace Sniper.Application
{
    public static class ApplicationKeys
    {
        public const string ApplicationProjectName = "Sniper";
        public const string PropertyName = "propertyName";
    }
}

namespace Sniper.Application.Messages
{
    public static class MessageKeys
    {
        public const string ConvertErrorFromUtf32RangeStandard = "The argument must be from 0 to 0x10FFFF.";
        public const string ConvertErrorFromUtf32RangeSurrogate = "The argument must not be in surrogate pair range.";
        public const string EmptyParameter = "Parameter cannot be empty";
        public const string EmptyPassword = "Passwords should never be null/empty";
        public const string EmptyValue = "Cannot contain null, empty or whitespace values";
        public const string FieldAndPropertyBothNull = "Property and Field cannot both be null";
        public const string JsonStringInvalid = "Invalid JSON string";
        public const string StandardKeyValueFormat = @"{0}:{1}";
        public const string TimespanZero = "Timespan must be greater than zero";
    }
}

namespace Sniper.Application.Parameters
{
    public static class ParameterKeys
    {
        public const string IgnoreField = "ignoreThisField";
        public const string Limit = "Limit";
        public const string Remaining = "Remaining";
        public const string Reset = "reset";
        public const string ResetAsUtcEpochSeconds = "ResetAsUtcEpochSeconds";
    }

}

namespace Sniper.Authentication
{
    public static class AuthenticationKeys
    {
        public const string AccessToken = "accessToken";
        public const string AuthenticationCode = "authenticationCode";
        public const string AuthorizationUpdate = "authorizationUpdate";
        public const string ClientId = "clientId";
        public const string ClientSecret = "clientSecret";
        public const string Code = "code";
        public const string CredentialStore = "credentialStore";
        public const string Credentials = "credentials";
        public const string CredentialsLogin = "credentials.Login";
        public const string CredentialsPassword = "credentials.Password";
        public const string NewAuthorization = "newAuthorization";
        public const string TwoFactorAuthenticationCode = "twoFactorAuthenticationCode";
        public const string UserName = "userName";

        internal static class Keys
        {
            public const string Authorization = "Authorization";
        }

        internal static class LDAP
        {
            public const string NewLdapMapping = "newLdapMapping";
            public const string TeamId = "teamId";
        }

        internal static class Messages
        {
            public const string BasicAuthorizationMessageFormat = @"Basic {0}";
            public const string TokenAuthorizationMessageFormat = @"Basic {0}";
            public const string EmptyPassword = "Passwords should never be null/empty";
            public const string TokenLoginFailed = "The Login is not null for a token authentication request. You probably did something wrong.";
        }
    }
}

namespace Sniper.FileAndDirectory
{
    public static class ConfigurationFiles
    {
        public const string ApplicationConfigurationFile = "sniper.json";
        internal static string ConfigurationDirectory = "_configuration";
        internal static string ConfigurationDirectoryFormat = $@"~\{ConfigurationDirectory}";
        internal static string ConfigurationDirectoryFileFormat = $@"{ConfigurationDirectoryFormat}\{{0}}";
        public const string LocalFile = "local";
    }

    public static class FileExtensions
    {
        public const string CloudConfig = "cscfg";
        public const string Html = "html";
        public const string Json = "json";
        public const string LocalConfig = "config";
        public const string Pdf = "pdf";
        public const string Text = "txt";
        public const string Xml = "xml";
    }

}

namespace Sniper.Http
{
    public static class HttpKeys
    {
        public const string First = "first";
        public const string Key = "key";
        public const string Last = "last";
        public const string Next = "next";
        public const string Pattern = "pattern";
        public const string Previous = "prev";
        public const string Uri = "uri";
        public const string Url = "url";

        internal static class HtmlKeys
        {
            public const string Body = "body";

            internal static class HeaderKeys
            {
                public const string Accept = "Accept";
                public const string Accepts = "accepts";
                public const string Content = "content";
                public const string Headers = "headers";
            }
        }

        internal static class RequestParameters
        {
            public const string Request = "request";
            public const string UpdateRequest = "updateRequest";
        }

        internal static class ResponseParameters
        {
            public const string Release = "release";
            public const string Response = "response";
            public const string ResponseHeaders = "responseHeaders";
            public const string ResponseMessage = "responseMessage";
        }
    }

    public static class Protocols
    {
        public const string HypertextSecure = "https";
        public const string HypertextUnsecure = "http";
    }
}

namespace Sniper.Licenses
{
    public static class LicenseKeys
    {
        public const string Category = "category";
        public const string Description = "description";
        public const string HtmlUrl = "htmlUrl";
        public const string Implementation = "implementation";
        public const string Key = "key";
    }
}

namespace Sniper.Paginations
{
    public static class PaginationKeys
    {
        public const string FirstPage = "getFirstPage";
        public const string Pagination = "pagination";
    }
}

namespace Sniper.Permissions
{
    public static class PermissionKeys
    {
        public const string Forbidden = "forbidden";
        public const string Permitted = "permitted";
        public const string Required = "required";
    }
}

namespace Sniper.Repositories
{
    public static class RepositoryKeys
    {
        public const string NewRepository = "newRepository";
        public const string Repository = "repository";
    }
}

namespace Sniper.Types
{
    public static class MimeTypes
    {
        ///<summary>JavaScript Object Notation JSON; Defined in RFC 4627</summary>
        public const string ApplicationJson = "application/json";
        public const string ApplicationFormUrlEncoded = "application/x-www-form-urlencoded";

        ///<summary>Arbitrary binary data.[5] Generally speaking this type identifies files that are not associated with a specific application. Contrary to past assumptions by software packages such as Apache this is not a type that should be applied to unknown files. In such a case, a server or application should not indicate a content type, as it may be incorrect, but rather, should omit the type in order to allow the recipient to guess the type.[6]</summary>
        public const string ApplicationOctetStream = "application/octet-stream";

        ///<summary>Gzip</summary>
        public const string ApplicationXGzip = "application/x-gzip";

        ///<summary>ZIP archive files; Registered[7]</summary>
        public const string ApplicationZip = "application/zip";
    }

}

#if false

namespace Sniper.Types
{
    public static class MimeTypes
    {
        ///<summary>Used to denote the encoding necessary for files containing JavaScript source code. The alternative MIME type for this file type is text/javascript.</summary>
        public const string ApplicationXJavascript = "application/x-javascript";

        ///<summary>24bit Linear PCM audio at 8-48kHz, 1-N channels; Defined in RFC 3190</summary>
        public const string AudioL24 = "audio/L24";

        ///<summary>Adobe Flash files for example with the extension .swf</summary>
        public const string ApplicationXShockwaveFlash = "application/x-shockwave-flash";


        ///<summary>Atom feeds</summary>
        public const string ApplicationAtomXml = "application/atom+xml";

        ///<summary>Cascading Style Sheets; Defined in RFC 2318</summary>
        public const string TextCss = "text/css";

        ///<summary>commands; subtype resident in Gecko browsers like Firefox 3.5</summary>
        public const string TextCmd = "text/cmd";

        ///<summary>Comma-separated values; Defined in RFC 4180</summary>
        public const string TextCsv = "text/csv";

        ///<summary>deb (file format), a software package format used by the Debian project</summary>
        public const string ApplicationXDeb = "application/x-deb";

        ///<summary>Defined in RFC 1847</summary>
        public const string MultipartEncrypted = "multipart/encrypted";

        ///<summary>Defined in RFC 1847</summary>
        public const string MultipartSigned = "multipart/signed";

        ///<summary>Defined in RFC 2616</summary>
        public const string MessageHttp = "message/http";

        ///<summary>Defined in RFC 4735</summary>
        public const string ModelExample = "model/example";

        ///<summary>device-independent document in DVI format</summary>
        public const string ApplicationXDvi = "application/x-dvi";

        ///<summary>DTD files; Defined by RFC 3023</summary>
        public const string ApplicationXmlDtd = "application/xml-dtd";

        ///<summary>ECMAScript/JavaScript; Defined in RFC 4329 (equivalent to application/ecmascript but with looser processing rules) It is not accepted in IE 8 or earlier - text/javascript is accepted but it is defined as obsolete in RFC 4329. The "type" attribute of the 'script' tag in HTML5 is optional and in practice omitting the media type of JavaScript programs is the most interoperable solution since all browsers have always assumed the correct default even before HTML5.</summary>
        public const string ApplicationJavascript = "application/javascript";

        ///<summary>ECMAScript/JavaScript; Defined in RFC 4329 (equivalent to application/javascript but with stricter processing rules)</summary>
        public const string ApplicationEcmascript = "application/ecmascript";

        ///<summary>EDI EDIFACT data; Defined in RFC 1767</summary>
        public const string ApplicationEdifact = "application/EDIFACT";

        ///<summary>EDI X12 data; Defined in RFC 1767</summary>
        public const string ApplicationEdiX12 = "application/EDI-X12";

        ///<summary>Email; Defined in RFC 2045 and RFC 2046</summary>
        public const string MessagePartial = "message/partial";

        ///<summary>Email; EML files, MIME files, MHT files, MHTML files; Defined in RFC 2045 and RFC 2046</summary>
        public const string MessageRfc822 = "message/rfc822";

        ///<summary>Extensible Markup Language; Defined in RFC 3023</summary>
        public const string TextXml = "text/xml";

        ///<summary>Extensible Markup Language; Defined in RFC 3023</summary>
        public const string ApplicationXml = "application/xml";

        ///<summary>Flash video (FLV files)</summary>
        public const string VideoXFlv = "video/x-flv";

        ///<summary>GIF image; Defined in RFC 2045 and RFC 2046</summary>
        public const string ImageGif = "image/gif";

        ///<summary>GoogleWebToolkit data</summary>
        public const string TextXGwtRpc = "text/x-gwt-rpc";

        ///<summary>HTML; Defined in RFC 2854</summary>
        public const string TextHtml = "text/html";

        ///<summary>ICO image; Registered[9]</summary>
        public const string ImageVndMicrosoftIcon = "image/vnd.microsoft.icon";

        ///<summary>IGS files, IGES files; Defined in RFC 2077</summary>
        public const string ModelIges = "model/iges";

        ///<summary>IMDN Instant Message Disposition Notification; Defined in RFC 5438</summary>
        public const string MessageImdnXml = "message/imdn+xml";


        ///<summary>JavaScript Object Notation (JSON) Patch; Defined in RFC 6902</summary>
        public const string ApplicationJsonPatch = "application/json-patch+json";

        ///<summary>JavaScript - Defined in and obsoleted by RFC 4329 in order to discourage its usage in favor of application/javascript. However,text/javascript is allowed in HTML 4 and 5 and, unlike application/javascript, has cross-browser support. The "type" attribute of the 'script' tag in HTML5 is optional and there is no need to use it at all since all browsers have always assumed the correct default (even in HTML 4 where it was required by the specification).</summary>
        [Obsolete]
        public const string TextJavascript = "text/javascript";

        ///<summary>JPEG JFIF image; Associated with Internet Explorer; Listed in ms775147(v=vs.85) - Progressive JPEG, initiated before global browser support for progressive JPEGs (Microsoft and Firefox).</summary>
        public const string ImagePjpeg = "image/pjpeg";

        ///<summary>JPEG JFIF image; Defined in RFC 2045 and RFC 2046</summary>
        public const string ImageJpeg = "image/jpeg";

        ///<summary>jQuery template data</summary>
        public const string TextXJqueryTmpl = "text/x-jquery-tmpl";

        ///<summary>KML files (e.g. for Google Earth)</summary>
        public const string ApplicationVndGoogleEarthKmlXml = "application/vnd.google-earth.kml+xml";

        ///<summary>LaTeX files</summary>
        public const string ApplicationXLatex = "application/x-latex";

        ///<summary>Matroska open media format</summary>
        public const string VideoXMatroska = "video/x-matroska";

        ///<summary>Microsoft Excel 2007 files</summary>
        public const string ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        ///<summary>Microsoft Excel files</summary>
        public const string ApplicationVndMsExcel = "application/vnd.ms-excel";

        ///<summary>Microsoft Powerpoint 2007 files</summary>
        public const string ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation = "application/vnd.openxmlformats-officedocument.presentationml.presentation";

        ///<summary>Microsoft Powerpoint files</summary>
        public const string ApplicationVndMsPowerpoint = "application/vnd.ms-powerpoint";

        ///<summary>Microsoft Word 2007 files</summary>
        public const string ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

        ///<summary>Microsoft Word files[15]</summary>
        public const string ApplicationMsword = "application/msword";

        ///<summary>MIME Email; Defined in RFC 2045 and RFC 2046</summary>
        public const string MultipartAlternative = "multipart/alternative";

        ///<summary>MIME Email; Defined in RFC 2045 and RFC 2046</summary>
        public const string MultipartMixed = "multipart/mixed";

        ///<summary>MIME Email; Defined in RFC 2387 and used by MHTML (HTML mail)</summary>
        public const string MultipartRelated = "multipart/related";

        ///<summary>MIME Webform; Defined in RFC 2388</summary>
        public const string MultipartFormData = "multipart/form-data";

        ///<summary>Mozilla XUL files</summary>
        public const string ApplicationVndMozillaXulXml = "application/vnd.mozilla.xul+xml";

        ///<summary>MP3 or other MPEG audio; Defined in RFC 3003</summary>
        public const string AudioMpeg = "audio/mpeg";

        ///<summary>MP4 audio</summary>
        public const string AudioMp4 = "audio/mp4";

        ///<summary>MP4 video; Defined in RFC 4337</summary>
        public const string VideoMp4 = "video/mp4";

        ///<summary>MPEG-1 video with multiplexed audio; Defined in RFC 2045 and RFC 2046</summary>
        public const string VideoMpeg = "video/mpeg";

        ///<summary>MSH files, MESH files; Defined in RFC 2077, SILO files</summary>
        public const string ModelMesh = "model/mesh";

        ///<summary>mulaw audio at 8 kHz, 1 channel; Defined in RFC 2046</summary>
        public const string AudioBasic = "audio/basic";

        ///<summary>Ogg Theora or other video (with audio); Defined in RFC 5334</summary>
        public const string VideoOgg = "video/ogg";

        ///<summary>Ogg Vorbis, Speex, Flac and other audio; Defined in RFC 5334</summary>
        public const string AudioOgg = "audio/ogg";

        ///<summary>Ogg, a multimedia bitstream container format; Defined in RFC 5334</summary>
        public const string ApplicationOgg = "application/ogg";

        ///<summary>OP</summary>
        public const string ApplicationXopXml = "application/xop+xml";

        ///<summary>OpenDocument Graphics; Registered[14]</summary>
        public const string ApplicationVndOasisOpendocumentGraphics = "application/vnd.oasis.opendocument.graphics";

        ///<summary>OpenDocument Presentation; Registered[13]</summary>
        public const string ApplicationVndOasisOpendocumentPresentation = "application/vnd.oasis.opendocument.presentation";

        ///<summary>OpenDocument Spreadsheet; Registered[12]</summary>
        public const string ApplicationVndOasisOpendocumentSpreadsheet = "application/vnd.oasis.opendocument.spreadsheet";

        ///<summary>OpenDocument Text; Registered[11]</summary>
        public const string ApplicationVndOasisOpendocumentText = "application/vnd.oasis.opendocument.text";

        ///<summary>p12 files</summary>
        public const string ApplicationXPkcs12 = "application/x-pkcs12";

        ///<summary>p7b and spc files</summary>
        public const string ApplicationXPkcs7Certificates = "application/x-pkcs7-certificates";

        ///<summary>p7c files</summary>
        public const string ApplicationXPkcs7Mime = "application/x-pkcs7-mime";

        ///<summary>p7r files</summary>
        public const string ApplicationXPkcs7Certreqresp = "application/x-pkcs7-certreqresp";

        ///<summary>p7s files</summary>
        public const string ApplicationXPkcs7Signature = "application/x-pkcs7-signature";

        ///<summary>Portable Document Format, PDF has been in use for document exchange on the Internet since 1993; Defined in RFC 3778</summary>
        public const string ApplicationPdf = "application/pdf";

        ///<summary>Portable Network Graphics; Registered,[8] Defined in RFC 2083</summary>
        public const string ImagePng = "image/png";

        ///<summary>PostScript; Defined in RFC 2046</summary>
        public const string ApplicationPostscript = "application/postscript";

        ///<summary>QuickTime video; Registered[10]</summary>
        public const string VideoQuicktime = "video/quicktime";

        ///<summary>RAR archive files</summary>
        public const string ApplicationXRarCompressed = "application/x-rar-compressed";

        ///<summary>RealAudio; Documented in RealPlayer Customer Support Answer 2559</summary>
        public const string AudioVndRnRealaudio = "audio/vnd.rn-realaudio";

        ///<summary>Resource Description Framework; Defined by RFC 3870</summary>
        public const string ApplicationRdfXml = "application/rdf+xml";

        ///<summary>RSS feeds</summary>
        public const string ApplicationRssXml = "application/rss+xml";

        ///<summary>SOAP; Defined by RFC 3902</summary>
        public const string ApplicationSoapXml = "application/soap+xml";

        ///<summary>StuffIt archive files</summary>
        public const string ApplicationXStuffit = "application/x-stuffit";

        ///<summary>SVG vector image; Defined in SVG Tiny 1.2 Specification Appendix M</summary>
        public const string ImageSvgXml = "image/svg+xml";

        ///<summary>Tag Image File Format (only for Baseline TIFF); Defined in RFC 3302</summary>
        public const string ImageTiff = "image/tiff";

        ///<summary>Tarball files</summary>
        public const string ApplicationXTar = "application/x-tar";

        ///<summary>Textual data; Defined in RFC 2046 and RFC 3676</summary>
        public const string TextPlain = "text/plain";

        ///<summary>TrueType Font No registered MIME type, but this is the most commonly used</summary>
        public const string ApplicationXFontTtf = "application/x-font-ttf";

        ///<summary>vCard (contact information); Defined in RFC 6350</summary>
        public const string TextVcard = "text/vcard";

        ///<summary>Vorbis encoded audio; Defined in RFC 5215</summary>
        public const string AudioVorbis = "audio/vorbis";

        ///<summary>WAV audio; Defined in RFC 2361</summary>
        public const string AudioVndWave = "audio/vnd.wave";

        ///<summary>Web Open Font Format; (candidate recommendation; use application/x-font-woff until standard is official)</summary>
        public const string ApplicationFontWoff = "application/font-woff";

        ///<summary>WebM Matroska-based open media format</summary>
        public const string VideoWebm = "video/webm";

        ///<summary>WebM open media format</summary>
        public const string AudioWebm = "audio/webm";

        ///<summary>Windows Media Audio Redirector; Documented in Microsoft help page</summary>
        public const string AudioXMsWax = "audio/x-ms-wax";

        ///<summary>Windows Media Audio; Documented in Microsoft KB 288102</summary>
        public const string AudioXMsWma = "audio/x-ms-wma";

        ///<summary>Windows Media Video; Documented in Microsoft KB 288102</summary>
        public const string VideoXMsWmv = "video/x-ms-wmv";

        ///<summary>WRL files, VRML files; Defined in RFC 2077</summary>
        public const string ModelVrml = "model/vrml";

        ///<summary>X3D ISO standard for representing 3D computer graphics, X3D XML files</summary>
        public const string ModelX3DXml = "model/x3d+xml";

        ///<summary>X3D ISO standard for representing 3D computer graphics, X3DB binary files</summary>
        public const string ModelX3DBinary = "model/x3d+binary";

        ///<summary>X3D ISO standard for representing 3D computer graphics, X3DV VRML files</summary>
        public const string ModelX3DVrml = "model/x3d+vrml";

        ///<summary>XHTML; Defined by RFC 3236</summary>
        public const string ApplicationXhtmlXml = "application/xhtml+xml";

    }
}
#endif


namespace Sniper.WarningsErrors
{
    public static class MessageSuppression
    {
        internal static class Categories
        {
            public const string Design = "Microsoft.Design";
            public const string Globalization = "Microsoft.Globalization";
            public const string Naming = "Microsoft.Naming";
            public const string Maintainability = "Microsoft.Maintainability";
            public const string Performance = "Microsoft.Performance";
            public const string Reliability = "Microsoft.Reliability";
            public const string Security = "Microsoft.Security";
            public const string Usage = "Microsoft.Usage";
        }

        internal static class MessageAttributes
        {
            public const string AvoidExcessiveComplexity = "CA1502:AvoidExcessiveComplexity";
            public const string AvoidUncalledPrivateCode = "CA1811:AvoidUncalledPrivateCode";
            public const string DisposeObjectsBeforeLosingScope = "CA2000:DisposeObjectsBeforeLosingScope";
            public const string DoNotDeclareReadOnlyMutableReferenceTypes = "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes";
            public const string IdentifiersShouldBeSpelledCorrectly = "CA1704:IdentifiersShouldBeSpelledCorrectly";
            public const string IdentifiersShouldHaveCorrectSuffix = "CA1710:IdentifiersShouldHaveCorrectSuffix";
            public const string IdentifiersShouldNotMatchKeywords = "CA1716:IdentifiersShouldNotMatchKeywords";
            public const string ImplementStandardExceptionConstructors = "CA1032:ImplementStandardExceptionConstructors";
            public const string NonConstantFieldsShouldNotBeVisible = "CA2211:NonConstantFieldsShouldNotBeVisible";
            public const string NormalizeStringsToUppercase = "CA1308:NormalizeStringsToUppercase";
            public const string ReviewUnusedParameters = "CA1801:ReviewUnusedParameters";
            public const string SpecifyIFormatProvider = "CA1305:SpecifyIFormatProvider";
            public const string TypeNamesShouldNotMatchNamespaces = "CA1724:TypeNamesShouldNotMatchNamespaces";
            public const string UseGenericsWhereAppropriate = "CA1007:UseGenericsWhereAppropriate";
            public const string UsePropertiesWhereAppropriate = "CA1024:UsePropertiesWhereAppropriate";
        }

        internal static class Justifications
        {
            public const string DotNet2Support = "Need to support .NET 2";
            public const string NetworkRequest = "Makes a network request";
            public const string ObjectIsImmutable = "This class/object is immutable";
            public const string SpecificToTargetProcess = "These exceptions are specific to the Target Process API and not general purpose exceptions";
            public const string LowercaseValueExpected = "The API expects lowercase.";
        }
    }

}
