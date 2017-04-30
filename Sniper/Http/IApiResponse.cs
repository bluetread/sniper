using System.Collections.Generic;

namespace Sniper.Http
{
    public interface IApiResponse<T>
    {
        /// <summary>
        /// Object deserialized from the JSON response body.
        /// </summary>
        ICollection<T> DataCollection { get; }

        /// <summary>
        /// Get individual item if list/collection has one result
        /// </summary>
        T Data { get; }

        /// <summary>
        /// The original non-deserialized http response.
        /// </summary>
        IHttpResponse HttpResponse { get; }
    }
}
