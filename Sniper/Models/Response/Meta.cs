#if false
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    /// <summary>
    /// Response from the /meta endpoint that provides information about GitHub.com or a GitHub Enterprise instance. 
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class Meta
    {
        /// <summary>
        /// Create an instance of the Meta
        /// </summary>
        public Meta()
        {
        }

        /// <summary>
        /// Create an instance of the Meta
        /// </summary>
        /// <param name="verifiablePasswordAuthentication">Whether authentication with username and password is supported.</param>
        /// <param name="gitHubServicesSha">The currently-deployed SHA of github-services.</param>
        /// <param name="hooks">An array of IP addresses in CIDR format specifying the addresses that incoming service hooks will originate from on GitHub.com.</param>
        /// <param name="git">An array of IP addresses in CIDR format specifying the Git servers for the GitHub server</param>
        /// <param name="pages">An array of IP addresses in CIDR format specifying the A records for GitHub Pages.</param>
        /// <param name="importer">An Array of IP addresses specifying the addresses that source imports will originate from on GitHub.com.</param>
        public Meta(
            bool verifiablePasswordAuthentication,
            string gitHubServicesSha,
            IReadOnlyList<string> hooks,
            IReadOnlyList<string> git,
            IReadOnlyList<string> pages,
            IReadOnlyList<string> importer)
        {
            VerifiablePasswordAuthentication = verifiablePasswordAuthentication;
            GitHubServicesSha = gitHubServicesSha;
            Hooks = hooks;
            Git = git;
            Pages = pages;
            Importer = importer;
        }

        /// <summary>
        /// Whether authentication with username and password is supported. (GitHub Enterprise instances using CAS or
        /// OAuth for authentication will return false. Features like Basic Authentication with a username and
        ///  password, sudo mode, and two-factor authentication are not supported on these servers.)
        /// </summary>
        public bool VerifiablePasswordAuthentication { get; }

        /// <summary>
        /// The currently-deployed SHA of github-services.
        /// </summary>
        [Parameter(Key = "github_services_sha")]
        public string GitHubServicesSha { get; }

        /// <summary>
        /// An Array of IP addresses in CIDR format specifying the addresses that incoming service hooks will
        /// originate from on GitHub.com. Subscribe to the API Changes blog or follow @GitHubAPI on Twitter to get
        /// updated when this list changes.
        /// </summary>
        public IReadOnlyList<string> Hooks { get; }

        /// <summary>
        /// An Array of IP addresses in CIDR format specifying the Git servers for GitHub.com.
        /// </summary>
        public IReadOnlyList<string> Git { get; }

        /// <summary>
        /// An Array of IP addresses in CIDR format specifying the A records for GitHub Pages.
        /// </summary>
        public IReadOnlyList<string> Pages { get; }

        /// <summary>
        /// An Array of IP addresses specifying the addresses that source imports will originate from on GitHub.com.
        /// </summary>
        public IReadOnlyList<string> Importer { get; }

        internal string DebuggerDisplay => string.Format(
            CultureInfo.InvariantCulture,
            "GitHubServicesSha: {0}, VerifiablePasswordAuthentication: {1} ",
            GitHubServicesSha,
            VerifiablePasswordAuthentication);
    }
}
#endif