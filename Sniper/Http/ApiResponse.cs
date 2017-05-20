using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sniper.Http
{
    /// <summary>
    /// Wrapper for a response from the API
    /// </summary>
    /// <typeparam name="T">Payload contained in the response</typeparam>
    public class ApiResponse<T> : IApiResponse<T>
    {
        /// <summary>
        /// Create a ApiResponse from an existing request
        /// </summary>
        /// <param name="response">An existing request to wrap</param>
        public ApiResponse(IHttpResponse response)
        {
            Ensure.ArgumentNotNull(nameof(response), response);

            HttpResponse = response;
            var data = response.Data;
            if (data == null || response.IsError)
            {
                DataCollection = null;
                return;

            }
            if (data.GetType() == typeof(T))
            {
                DataCollection = new Collection<T> { (T)data };
            }
            else
            {
                DataCollection = (ICollection<T>)data;
            }
        }

        /// <summary>
        /// Create a ApiResponse from an existing request and object
        /// </summary>
        /// <param name="response">An existing request to wrap</param>
        /// <param name="dataAsObject">The payload from an existing request</param>
        public ApiResponse(IHttpResponse response, T dataAsObject) : this(response, new Collection<T> { dataAsObject }) { }

        /// <summary>
        /// Create a ApiResponse from an existing request and object
        /// </summary>
        /// <param name="response">An existing request to wrap</param>
        /// <param name="dataAsObject">The payload from an existing request</param>
        public ApiResponse(IHttpResponse response, ICollection<T> dataAsObject)
        {
            Ensure.ArgumentNotNull(nameof(response), response);

            HttpResponse = response;
            DataCollection = dataAsObject;
        }

        /// <summary>
        /// The payload of the response
        /// </summary>
        public ICollection<T> DataCollection { get; }

        /// <summary>
        /// Get individual item if list/collection has one result
        /// </summary>
        public T Data => (DataCollection != null && DataCollection.Count == 1) ? DataCollection.First() : default(T);

        /// <summary>
        /// The context of the response
        /// </summary>
        public IHttpResponse HttpResponse { get; }
    }
}