using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Sniper.Http
{
    public class ReadOnlyPagedCollection<T> : ReadOnlyCollection<T>, IReadOnlyPagedCollection<T>
    {
        private readonly ApiInfo _info;
        private readonly Func<Uri, Task<IApiResponse<List<T>>>> _nextPageFunc;

        public ReadOnlyPagedCollection(IApiResponse<List<T>> response, Func<Uri, Task<IApiResponse<List<T>>>> nextPageFunc)
            : base(response != null ? response.Body ?? new List<T>() : new List<T>())
        {
            Ensure.ArgumentNotNull(nameof(response), response);
            Ensure.ArgumentNotNull(nameof(nextPageFunc), nextPageFunc);

            _nextPageFunc = nextPageFunc;
            if (response != null)
            {
                _info = response.HttpResponse.ApiInfo;
            }
        }

        public async Task<IReadOnlyPagedCollection<T>> GetNextPage()
        {
            var nextPageUrl = _info.GetNextPageUrl();
            if (nextPageUrl == null) return null;

            var maybeTask = _nextPageFunc(nextPageUrl);

            if (maybeTask == null)
            {
                return null;
            }

            var response = await maybeTask.ConfigureAwait(false);
            return new ReadOnlyPagedCollection<T>(response, _nextPageFunc);
        }
    }
}
