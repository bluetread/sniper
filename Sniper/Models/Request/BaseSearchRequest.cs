#if false
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Sniper.Request
{
    /// <summary>
    /// Base class for searching issues/code/users/repos
    /// </summary>
    [SuppressMessage(Categories.Design, "CA1012:AbstractTypesShouldNotHaveConstructors")]
    public abstract class BaseSearchRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchRequest"/> class.
        /// </summary>
        protected BaseSearchRequest()
        {
            Page = 1;
            PerPage = 100;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchRequest"/> class.
        /// </summary>
        /// <param name="term">The term.</param>
        protected BaseSearchRequest(string term) : this()
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(term), term);
            Term = term;
        }

        /// <summary>
        /// The search term
        /// </summary>
        public string Term { get; }


        /// <summary>
        /// Page of paginated results
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Number of items per page
        /// </summary>
        public int PerPage { get; set; }

        /// <summary>
        /// All qualifiers that are used for this search
        /// </summary>
        public abstract IReadOnlyList<string> MergedQualifiers();
    }
}
#endif