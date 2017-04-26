using Sniper.Contracts;
using static Sniper.TargetProcess.Enumerations;

namespace Sniper.Common
{
    /// <summary>
    /// Global Application Settings.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/GlobalSettings/meta">API documentation - GlobalSettings</a>
    /// </remarks>
    public class GlobalSettings : IHasId
    {
        public int Id { get; set; }
        public string AppHostAndPath { get; set; }
        public string CompanyName { get; set; }
        public string CsvExportDelimiter { get; set; }
        public bool DisableHttpAccess { get; set; }
        public string HelpDeskPortalPath { get; set; }
        public bool IsEmailNotificationsEnabled { get; set; }
        public bool NotifyAutoCreatedRequester { get; set; }
        public bool NotifyRequester { get; set; }
        public bool SecureJsonp { get; set; }
        public bool SmtpAuthentication { get; set; }
        public string SmtpPassword { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpSender { get; set; }
        public string SmtpServer { get; set; }
        public bool Tp3Available { get; set; }
        public RichEditorType DefaultRichEditor { get; set; }
        public SsoSettings SsoSettings { get; set; }
    }
}
