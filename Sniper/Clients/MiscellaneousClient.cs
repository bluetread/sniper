using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Sniper.Http;
using Sniper.Request;
using Sniper.Response;
using System.Collections.ObjectModel;
using Sniper.ApiClients;

namespace Sniper
{
    /// <summary>
    /// A client for GitHub's miscellaneous APIs.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/misc/">Miscellaneous API documentation</a> for more details.
    /// </remarks>
    public class MiscellaneousClient : IMiscellaneousClient
    {
        private readonly IConnection _connection;

        /// <summary>
        ///     Initializes a new GitHub miscellaneous API client.
        /// </summary>
        /// <param name="connection">An API connection</param>
        public MiscellaneousClient(IConnection connection)
        {
            Ensure.ArgumentNotNull(ApiClientKeys.Connection, connection);

            _connection = connection;
        }

       /// <summary>
        /// Gets the rendered Markdown for the specified plain-text Markdown document.
        /// </summary>
        /// <param name="markdown">A plain-text Markdown document</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>The rendered Markdown.</returns>
        public async Task<string> RenderRawMarkdown(string markdown)
        {
            var endpoint = new Uri("markdown/raw", UriKind.Relative);
            var response = await _connection.Post<string>(endpoint, markdown, "text/html", "text/plain").ConfigureAwait(false);
            return response.Body;
        }

        /// <summary>
        /// Gets the rendered Markdown for an arbitrary markdown document.
        /// </summary>
        /// <param name="markdown">An arbitrary Markdown document</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>The rendered Markdown.</returns>
        public async Task<string> RenderArbitraryMarkdown(NewArbitraryMarkdown markdown)
        {
            var endpoint = new Uri("markdown", UriKind.Relative);
            var response = await _connection.Post<string>(endpoint, markdown, "text/html", "text/plain").ConfigureAwait(false);
            return response.Body;
        }

   
        /// <summary>
        /// Returns a list of the licenses shown in the license picker on GitHub.com. This is not a comprehensive
        /// list of all possible OSS licenses.
        /// </summary>
        /// <remarks>This is a PREVIEW API! Use it at your own risk.</remarks>
        /// <returns>A list of licenses available on the site</returns>
        public async Task<IReadOnlyList<LicenseMetadata>> GetAllLicenses()
        {
            var endpoint = new Uri("licenses", UriKind.Relative);

            var response = await _connection.Get<LicenseMetadata[]>(endpoint, null, AcceptHeaders.LicensesApiPreview).ConfigureAwait(false);
            return new ReadOnlyCollection<LicenseMetadata>(response.Body);
        }

        /// <summary>
        /// Retrieves a license based on the license key such as "mit"
        /// </summary>
        /// <param name="key"></param>
        /// <returns>A <see cref="License" /> that includes the license key, text, and attributes of the license.</returns>
        public async Task<License> GetLicense(string key)
        {
            var endpoint = new Uri("licenses/" + Uri.EscapeUriString(key), UriKind.Relative);

            var response = await _connection.Get<License>(endpoint, null, AcceptHeaders.LicensesApiPreview).ConfigureAwait(false);
            return response.Body;
        }

        /// <summary>
        /// Gets API Rate Limits (API service rather than header info).
        /// </summary>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>An <see cref="MiscellaneousRateLimit"/> of Rate Limits.</returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public async Task<MiscellaneousRateLimit> GetRateLimits()
        {
            var endpoint = new Uri("rate_limit", UriKind.Relative);
            var response = await _connection.Get<MiscellaneousRateLimit>(endpoint, null, null).ConfigureAwait(false);
            return response.Body;
        }

        /// <summary>
        /// Retrieves information about GitHub.com, the service or a GitHub Enterprise installation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>An <see cref="Meta"/> containing metadata about the GitHub instance.</returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public async Task<Meta> GetMetadata()
        {
            var endpoint = new Uri("meta", UriKind.Relative);
            var response = await _connection.Get<Meta>(endpoint, null, null).ConfigureAwait(false);
            return response.Body;
        }
    }
}