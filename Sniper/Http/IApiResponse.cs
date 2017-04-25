namespace Sniper.Http
{
    public interface IApiResponse<out T>
    {
        /// <summary>
        /// Object deserialized from the JSON response body.
        /// </summary>
        T Body { get; }

        /// <summary>
        /// The original non-deserialized http response.
        /// </summary>
        IHttpResponse HttpResponse { get; }
    }
}
