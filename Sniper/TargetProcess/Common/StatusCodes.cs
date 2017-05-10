using System.Collections.Generic;
using static Sniper.TargetProcess.StatusCodes;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.TargetProcess.Common
{
    public static class StatusCodes
    {
        public enum StatusCode
        {
            None = 0,
            Success = 200,
            BadFormat = 400,
            Unauthorized = 401,
            Forbidden = 403,
            RequestedEntityNotFound = 404,
            InternalServerError = 500,
            NotImplemented = 501
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(Categories.Security, MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<StatusCode, KeyValuePair<string, string>> StatusCodeMessages = new Dictionary<StatusCode, KeyValuePair<string, string>>
        {
            { StatusCode.Success, new KeyValuePair<string, string>(StatusCodeTitles.Success, StatusCodeDetails.Success) },
            { StatusCode.BadFormat, new KeyValuePair<string, string>(StatusCodeTitles.BadFormat, StatusCodeDetails.BadFormat) },
            { StatusCode.Unauthorized, new KeyValuePair<string, string>(StatusCodeTitles.Unauthorized, StatusCodeDetails.Unauthorized) },
            { StatusCode.Forbidden, new KeyValuePair<string, string>(StatusCodeTitles.Forbidden, StatusCodeDetails.Forbidden) },
            { StatusCode.RequestedEntityNotFound, new KeyValuePair<string, string>(StatusCodeTitles.RequestedEntityNotFound, string.Empty) },
            { StatusCode.InternalServerError, new KeyValuePair<string, string>(StatusCodeTitles.InternalServerError, StatusCodeDetails.InternalServerError) },
            { StatusCode.NotImplemented, new KeyValuePair<string, string>(StatusCodeTitles.NotImplemented, StatusCodeDetails.NotImplemented) }
        };
    }
}