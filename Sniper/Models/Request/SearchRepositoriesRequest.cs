using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace Sniper.Request
{
    /// <summary>
    /// Searching Repositories
    /// http://developer.github.com/v3/search/#search-repositories
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchRepositoriesRequest : BaseSearchRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepositoriesRequest"/> class.
        /// </summary>
        public SearchRepositoriesRequest()
        {
            Order = SortDirection.Descending;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepositoriesRequest"/> class.
        /// </summary>
        /// <param name="term">The search term.</param>
        public SearchRepositoriesRequest(string term)
            : base(term)
        {
            Order = SortDirection.Descending;
        }

      

        private IEnumerable<InQualifier> _inQualifier;

        /// <summary>
        /// The in qualifier limits what fields are searched. With this qualifier you can restrict the search to just the repository name, description, README, or any combination of these. 
        /// Without the qualifier, only the name and description are searched.
        /// https://help.github.com/articles/searching-repositories#search-in
        /// </summary>
        public IEnumerable<InQualifier> In
        {
            get
            {
                return _inQualifier;
            }
            set
            {
                if (value != null && value.Any())
                    _inQualifier = value.Distinct().ToList();
            }
        }


        /// <summary>
        /// The size qualifier finds repository's that match a certain size (in kilobytes).
        /// https://help.github.com/articles/searching-repositories#size
        /// </summary>
        public Range Size { get; set; }

      
        /// <summary>
        /// Limits searches to a specific user or repository.
        /// https://help.github.com/articles/searching-repositories#users-organizations-and-repositories
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Filters repositories based on times of creation.
        /// https://help.github.com/articles/searching-repositories#created-and-last-updated
        /// </summary>
        public DateRange Created { get; set; }

        /// <summary>
        /// Filters repositories based on when they were last updated.
        /// https://help.github.com/articles/searching-repositories#created-and-last-updated
        /// </summary>
        public DateRange Updated { get; set; }

        public override IReadOnlyList<string> MergedQualifiers()
        {
            var parameters = new List<string>();

            if (In != null)
            {
                parameters.Add(string.Format(CultureInfo.InvariantCulture, "in:{0}", string.Join(",", In)));
            }

            if (Size != null)
            {
                parameters.Add(string.Format(CultureInfo.InvariantCulture, "size:{0}", Size));
            }

            if (User.IsNotBlank())
            {
                parameters.Add(string.Format(CultureInfo.InvariantCulture, "user:{0}", User));
            }

            if (Created != null)
            {
                parameters.Add(string.Format(CultureInfo.InvariantCulture, "created:{0}", Created));
            }

         
            return parameters;
        }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Term: {0}", Term);
            }
        }
    }

    /// <summary>
    /// https://help.github.com/articles/searching-repositories#search-in
    /// The in qualifier limits what fields are searched. With this qualifier you can restrict the search to just the 
    /// repository name, description, README, or any combination of these.
    /// </summary>
    public enum InQualifier
    {
        Name,
        Description,
        Readme
    }

    /// <summary>
    /// Helper class in generating the range values for a qualifer e.g. In or Size qualifiers
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Range
    {
        private readonly string _query = string.Empty;

        /// <summary>
        /// Matches repositories that are <param name="size">size</param> MB exactly
        /// </summary>
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.Int32.ToString")]
        public Range(int size)
        {
            _query = size.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Matches repositories that are between <param name="minSize"/> and <param name="maxSize"/> KB
        /// </summary>
        public Range(int minSize, int maxSize)
        {
            _query = string.Format(CultureInfo.InvariantCulture, "{0}..{1}", minSize, maxSize);
        }

        /// <summary>
        /// Matches repositories with regards to the size <param name="size"/> 
        /// We will use the <param name="op"/> to see what operator will be applied to the size qualifier
        /// </summary>
        public Range(int size, SearchQualifierOperator op)
        {
            switch (op)
            {
                case SearchQualifierOperator.GreaterThan:
                    _query = string.Format(CultureInfo.InvariantCulture, ">{0}", size);
                    break;
                case SearchQualifierOperator.LessThan:
                    _query = string.Format(CultureInfo.InvariantCulture, "<{0}", size);
                    break;
                case SearchQualifierOperator.LessThanOrEqualTo:
                    _query = string.Format(CultureInfo.InvariantCulture, "<={0}", size);
                    break;
                case SearchQualifierOperator.GreaterThanOrEqualTo:
                    _query = string.Format(CultureInfo.InvariantCulture, ">={0}", size);
                    break;
            }
        }

        internal string DebuggerDisplay
        {
            get { return string.Format(CultureInfo.InvariantCulture, "Query: {0}", _query); }
        }

        /// <summary>
        /// Helper class that build a <see cref="Range"/> with a LessThan comparator used for filtering results
        /// </summary>
        public static Range LessThan(int size)
        {
            return new Range(size, SearchQualifierOperator.LessThan);
        }

        /// <summary>
        /// Helper class that build a <see cref="Range"/> with a LessThanOrEqual comparator used for filtering results
        /// </summary>
        public static Range LessThanOrEquals(int size)
        {
            return new Range(size, SearchQualifierOperator.LessThanOrEqualTo);
        }

        /// <summary>
        /// Helper class that build a <see cref="Range"/> with a GreaterThan comparator used for filtering results
        /// </summary>
        public static Range GreaterThan(int size)
        {
            return new Range(size, SearchQualifierOperator.GreaterThan);
        }

        /// <summary>
        /// Helper class that build a <see cref="Range"/> with a GreaterThanOrEqualTo comparator used for filtering results
        /// </summary>
        public static Range GreaterThanOrEquals(int size)
        {
            return new Range(size, SearchQualifierOperator.GreaterThanOrEqualTo);
        }

        public override string ToString()
        {
            return _query;
        }
    }

    /// <summary>
    /// helper class in generating the date range values for the date qualifier e.g.
    /// https://help.github.com/articles/searching-repositories#created-and-last-updated
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class DateRange
    {
        private readonly string _query = string.Empty;

        /// <summary>
        /// Matches repositories with regards to the <param name="date"/>.
        /// We will use the <param name="op"/> to see what operator will be applied to the date qualifier
        /// </summary>
        public DateRange(DateTime date, SearchQualifierOperator op)
        {
            switch (op)
            {
                case SearchQualifierOperator.GreaterThan:
                    _query = string.Format(CultureInfo.InvariantCulture, ">{0:yyyy-MM-dd}", date);
                    break;
                case SearchQualifierOperator.LessThan:
                    _query = string.Format(CultureInfo.InvariantCulture, "<{0:yyyy-MM-dd}", date);
                    break;
                case SearchQualifierOperator.LessThanOrEqualTo:
                    _query = string.Format(CultureInfo.InvariantCulture, "<={0:yyyy-MM-dd}", date);
                    break;
                case SearchQualifierOperator.GreaterThanOrEqualTo:
                    _query = string.Format(CultureInfo.InvariantCulture, ">={0:yyyy-MM-dd}", date);
                    break;
            }
        }

        /// <summary>
        /// Matches repositories with regards to both the <param name="from"/> and <param name="to"/> dates.
        /// </summary>
        public DateRange(DateTime from, DateTime to)
        {
            _query = string.Format(CultureInfo.InvariantCulture, "{0:yyyy-MM-dd}..{1:yyyy-MM-dd}", from, to);
        }

        internal string DebuggerDisplay
        {
            get { return string.Format(CultureInfo.InvariantCulture, "Query: {0}", _query); }
        }

        /// <summary>
        /// helper method to create a LessThan Date Comparison
        /// e.g. &lt; 2011
        /// </summary>
        /// <param name="date">date to be used for comparison (times are ignored)</param>
        /// <returns><see cref="DateRange"/></returns>
        public static DateRange LessThan(DateTime date)
        {
            return new DateRange(date, SearchQualifierOperator.LessThan);
        }

        /// <summary>
        /// helper method to create a LessThanOrEqualTo Date Comparison
        /// e.g. &lt;= 2011
        /// </summary>
        /// <param name="date">date to be used for comparison (times are ignored)</param>
        /// <returns><see cref="DateRange"/></returns>
        public static DateRange LessThanOrEquals(DateTime date)
        {
            return new DateRange(date, SearchQualifierOperator.LessThanOrEqualTo);
        }

        /// <summary>
        /// helper method to create a GreaterThan Date Comparison
        /// e.g. > 2011
        /// </summary>
        /// <param name="date">date to be used for comparison (times are ignored)</param>
        /// <returns><see cref="DateRange"/></returns>
        public static DateRange GreaterThan(DateTime date)
        {
            return new DateRange(date, SearchQualifierOperator.GreaterThan);
        }

        /// <summary>
        /// helper method to create a GreaterThanOrEqualTo Date Comparison
        /// e.g. >= 2011
        /// </summary>
        /// <param name="date">date to be used for comparison (times are ignored)</param>
        /// <returns><see cref="DateRange"/></returns>
        public static DateRange GreaterThanOrEquals(DateTime date)
        {
            return new DateRange(date, SearchQualifierOperator.GreaterThanOrEqualTo);
        }

        /// <summary>
        /// helper method to create a bounded Date Comparison
        /// e.g. 2015-08-01..2015-10-31
        /// </summary>
        /// <param name="from">earlier date of the two</param>
        /// <param name="to">latter date of the two</param>
        /// <returns><see cref="DateRange"/></returns>
        public static DateRange Between(DateTime from, DateTime to)
        {
            return new DateRange(from, to);
        }

        public override string ToString()
        {
            return _query;
        }
    }
}