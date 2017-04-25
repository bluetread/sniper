#if false
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Sniper.ApiClients;
using Sniper.Http;
using Sniper.Request;
using Sniper.Response;
using Sniper.Types;

namespace Sniper
{
    /// <summary>
    /// Provides methods used in the OAuth web flow.  //TODO: Replace with TargetProcess if this is usable
    /// </summary>
    public class OAuthClient : IOAuthClient
    {
        private readonly IConnection _connection;
        private readonly Uri _hostAddress;

        /// <summary>
        /// Create an instance of the OauthClient
        /// </summary>
        /// <param name="connection">The underlying connection to use</param>
        public OAuthClient(IConnection connection)
        {
            Ensure.ArgumentNotNull(nameof(connection), connection);

            _connection = connection;
            var baseAddress = connection.BaseAddress ?? TargetProcessClient.TargetProcessDotComUrl;

            // The Oauth login stuff uses https://github.com and not the https://api.github.com URLs.  //TODO: Replace with TargetProcess if this is usable
            _hostAddress = baseAddress.Host.Equals("api.github.com")
                ? new Uri("https://github.com")
                : baseAddress;
        }

        /// <summary>
        /// Gets the URL used in the first step of the web flow. The Web application should redirect to this URL.
        /// </summary>
        /// <param name="request">Parameters to the Oauth web flow login url</param>
        /// <returns></returns>
        public Uri GetGitHubLoginUrl(OAuthLoginRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            return new Uri(_hostAddress, ApiUrls.OauthAuthorize())
                .ApplyParameters(request.ToParametersDictionary());
        }

        /// <summary>
        /// Makes a request to get an access token using the code returned when GitHub.com redirects back from the URL
        /// <see cref="GetGitHubLoginUrl">GitHub login url</see> to the application.
        /// </summary>
        /// <remarks>
        /// If the user accepts your request, GitHub redirects back to your site with a temporary code in a code
        /// parameter as well as the state you provided in the previous step in a state parameter. If the states don’t
        /// match, the request has been created by a third party and the process should be aborted. Exchange this for
        /// an access token using this method.
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<OAuthToken> CreateAccessToken(OAuthTokenRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            var endPoint = ApiUrls.OauthAccessToken();

            var body = new FormUrlEncodedContent(request.ToParametersDictionary());

            var response = await _connection.Post<OAuthToken>(endPoint, body, MimeTypes.ApplicationJson, null, _hostAddress).ConfigureAwait(false);
            return response.Body;
        }
    }
}
#endif