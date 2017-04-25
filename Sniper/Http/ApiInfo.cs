using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sniper.Http
{
    /// <summary>
    /// Extra information returned as part of each api response.
    /// </summary>
    public class ApiInfo
    {
        public ApiInfo(IDictionary<string, Uri> links, IList<string> oauthScopes, IList<string> acceptedOAuthScopes)
        {
            Ensure.ArgumentNotNull(nameof(links), links);
            Ensure.ArgumentNotNull(nameof(oauthScopes), oauthScopes);

            Links = new ReadOnlyDictionary<string, Uri>(links);
            OauthScopes = new ReadOnlyCollection<string>(oauthScopes);
            AcceptedOAuthScopes = new ReadOnlyCollection<string>(acceptedOAuthScopes);
        }

        /// <summary>
        /// Oauth scopes that were included in the token used to make the request.
        /// </summary>
        public IReadOnlyList<string> OauthScopes { get; }

        /// <summary>
        /// Oauth scopes accepted for this particular call.
        /// </summary>
        public IReadOnlyList<string> AcceptedOAuthScopes { get; }

        /// <summary>
        /// Links to things like next/previous pages
        /// </summary>
        public IReadOnlyDictionary<string, Uri> Links { get; }

        ///// <summary>
        ///// Information about the API rate limit
        ///// </summary>
        //public RateLimit RateLimit { get; }

        /// <summary>
        /// Allows you to clone ApiInfo 
        /// </summary>
        /// <returns>A clone of <seealso cref="ApiInfo"/></returns>
        public ApiInfo Clone()
        {
            // Seem to have to do this to pass a whole bunch of tests (for example Sniper.Tests.Clients.EventsClientTests.DeserializesCommitCommentEventCorrectly)
            // I believe this has something to do with the Mocking framework.
            if (Links == null || OauthScopes == null/* || RateLimit == null*/)
                return null;

            return new ApiInfo(Links.Clone(), OauthScopes.Clone(), AcceptedOAuthScopes.Clone()/*, RateLimit.Clone()*/);
        }
    }
}
