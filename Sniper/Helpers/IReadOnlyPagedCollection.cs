using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    /// <summary>
    /// Reflects a collection of data returned from an API that can be paged.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadOnlyPagedCollection<T> : IReadOnlyList<T>
    {
        /// <summary>
        /// Returns the next page of items.
        /// </summary>
        /// <returns></returns>
        [SuppressMessage(Categories.Design, MessageAttributes.UsePropertiesWhereAppropriate, Justification = Justifications.NetworkRequest)]
        Task<IReadOnlyPagedCollection<T>> GetNextPage();
    }
}
