using Sniper.Http;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;
using System.Security;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    /// <summary>
    /// Represents errors that occur from the GitHub API.
    /// </summary>

    [Serializable]

    [SuppressMessage(Categories.Design, MessageAttributes.ImplementStandardExceptionConstructors, Justification = Justifications.SpecificToTargetProcess)]
    public class ApiException : Exception
    {


        /// <summary>
        /// Constructs an instance of ApiException
        /// </summary>
        public ApiException() : this(new Response()) { }
        public ApiException(HttpStatusCode statusCode) : base(statusCode.ToString()) { } //TODO: look at this again... compare to original file

        /// <summary>
        /// Constructs an instance of ApiException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        public ApiException(IResponse response) : this(response, null) { }

        /// <summary>
        /// Constructs an instance of ApiException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="innerException">The inner exception</param>
        public ApiException(IResponse response, Exception innerException) : base(null, innerException)
        {
            Ensure.ArgumentNotNull(HttpKeys.ResponseParameters.Response, response);
            StatusCode = response.StatusCode;
            HttpResponse = response;
        }




        public IResponse HttpResponse { get; }


        /// <summary>
        /// The HTTP status code associated with the repsonse
        /// </summary>
        public HttpStatusCode StatusCode { get; }


        /// <summary>
        /// Get the inner http response body from the API response
        /// </summary>
        /// <remarks>
        /// Returns empty string if HttpResponse is not populated or if
        /// response body is not a string
        /// </remarks>
        protected string HttpResponseBodySafe => HttpResponse != null
                                                 && !HttpResponse.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase)
                                                 && HttpResponse.Body is string
            ? (string)HttpResponse.Body : string.Empty;

        public override string ToString()
        {
            var original = base.ToString();
            return original + Environment.NewLine + HttpResponseBodySafe;
        }

        [SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("HttpStatusCode", StatusCode);
            //info.AddValue("ApiError", ApiError);
        }
    }
}
