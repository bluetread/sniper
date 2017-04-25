namespace Sniper.TargetProcess.Api
{
    public static class Filtering
    {
        public enum FilterOperator
        {
            Contains,
            Equality,
            GreaterThan,
            GreaterThanOrEqual,
            InList,
            IsNull,
            IsNotNull,
            LessThan,
            LessThanOrEqual,
            NotEquality
        }

        public enum DataFilter
        {
            Append,
            Exclude,
            Include,
            InnerTake,
            Skip,
            Take,
            Where
        }
    }
}
