using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using Sniper.Http;
using Sniper.ToBeRemoved;

namespace Sniper.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Readme
    {
        private readonly Lazy<Task<string>> _htmlContent;

        public Readme() { }

        internal Readme(ReadmeResponse response, IApiConnection client)
        {
            Ensure.ArgumentNotNull(HttpKeys.ResponseParameters.Response, response);
            Ensure.ArgumentNotNull(OldGitHubToBeRemoved.Client, client);
            
            Name = response.Name;
            Url = new Uri(response.Url);
            HtmlUrl = new Uri(response.HtmlUrl);
            if (response.Encoding.Equals("base64", StringComparison.OrdinalIgnoreCase))
            {
                var contentAsBytes = Convert.FromBase64String(response.Content);
                Content = Encoding.UTF8.GetString(contentAsBytes, 0, contentAsBytes.Length);
            }
            _htmlContent = new Lazy<Task<string>>(async () => await client.GetHtml(Url).ConfigureAwait(false));
        }

        public Readme(Lazy<Task<string>> htmlContent, string content, string name, Uri htmlUrl, Uri url)
        {
            _htmlContent = htmlContent;
            Content = content;
            Name = name;
            HtmlUrl = htmlUrl;
            Url = url;
        }

        public string Content { get; }
        public string Name { get; }
        public Uri HtmlUrl { get; }
        public Uri Url { get; }

        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate",
            Justification = "Makes a network request")]
        public Task<string> GetHtmlContent()
        {
            return _htmlContent.Value;
        }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Name: {0} ", Name);
            }
        }
    }
}