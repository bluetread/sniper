using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;
namespace Sniper.Common
{
    /// <summary>
    /// Global Application Settings.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/GlobalSettings/meta">API documentation - GlobalSettings</a>
    /// </remarks>
    [CanUpdate]
    public class GlobalSettings : Entity
    {
        [JsonProperty(Required = Required.Default)]
        public string AppHostAndPath { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string CompanyName { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string CsvExportDelimiter { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool DisableHttpAccess { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string HelpDeskPortalPath { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsEmailNotificationsEnabled { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool NotifyAutoCreatedRequester { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool NotifyRequester { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool SecureJsonp { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool SmtpAuthentication { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string SmtpPassword { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int SmtpPort { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string SmtpSender { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string SmtpServer { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool Tp3Available { get; set; }

        [JsonProperty(Required = Required.Default)]
        public RichEditorType DefaultRichEditor { get; set; }

        [JsonProperty(Required = Required.Default)]
        public SsoSettings SsoSettings { get; set; }
    }
}