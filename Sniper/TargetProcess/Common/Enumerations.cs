namespace Sniper.TargetProcess.Common
{
    public static class Enumerations
    {
        public enum Aggregate
        {
            Average,
            Count,
            Maximum,
            Minimum,
            Sum
        }

        //Assign values just in case sorting alters the mappings
        public enum ContentType
        {
            Error = 2,
            Email = 3,
            Mail = 1,
            None = 0
        }

        public enum CustomFieldScope { None, Global, Process }

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

        //Assign values just in case sorting alters the mappings
        public enum FieldType
        {
            CheckBox = 3,
            Date = 5,
            DropDown = 2,
            Entity = 9,
            Money = 8,
            None = 0,
            Number = 7,
            RichText = 6,
            Text = 1,
            Url = 4
        }

        //Assign values just in case sorting alters the mappings
        public enum FileAction
        {
            Add = 1,
            Delete = 2,
            Modify = 3,
            None = 0,
            Rename = 4
        }

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

        public enum RichEditorType
        {
            Html = 0,
            Markdown = 1
        }

        //Assign values just in case sorting alters the mappings
        public enum MessageType
        {
            Inbox = 1,
            None = 0,
            Outbox = 2,
            Public = 3
        }

        public enum RequestSource
        {
            Email = 1,
            External = 4,
            Internal = 3,
            None = 0,
            Phone = 2
        }

        public enum RequesterSourceType
        {
            External = 2,
            Internal = 3,
            Mail = 1,
            None = 0
        }

        public enum SortOrder
        {
            Ascending,
            Descending
        }

        public enum TestCaseRunStatus
        {
            NotRun,
            Passed,
            Failed,
            OnHold,
            Blocked
        }

        public enum UserEntityKind
        {
            Contact = 4,
            None = 0,
            Requester = 3,
            SystemUser = 2,
            User = 1
        }
    }
}
