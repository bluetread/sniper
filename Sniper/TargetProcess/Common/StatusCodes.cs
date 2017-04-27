using Sniper.WarningsErrors;
using System.Collections.Generic;

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage(MessageSuppression.Categories.Security, MessageSuppression.MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<StatusCode, KeyValuePair<string, string>> StatusCodeMessages = new Dictionary<StatusCode, KeyValuePair<string, string>>
        {
            { StatusCode.Success, new KeyValuePair<string, string>(TargetProcess.StatusCodes.StatusCodeTitles.Success, TargetProcess.StatusCodes.StatusCodeDetails.Success) },
            { StatusCode.BadFormat, new KeyValuePair<string, string>(TargetProcess.StatusCodes.StatusCodeTitles.BadFormat, TargetProcess.StatusCodes.StatusCodeDetails.BadFormat) },
            { StatusCode.Unauthorized, new KeyValuePair<string, string>(TargetProcess.StatusCodes.StatusCodeTitles.Unauthorized, TargetProcess.StatusCodes.StatusCodeDetails.Unauthorized) },
            { StatusCode.Forbidden, new KeyValuePair<string, string>(TargetProcess.StatusCodes.StatusCodeTitles.Forbidden, TargetProcess.StatusCodes.StatusCodeDetails.Forbidden) },
            { StatusCode.RequestedEntityNotFound, new KeyValuePair<string, string>(TargetProcess.StatusCodes.StatusCodeTitles.RequestedEntityNotFound, string.Empty) },
            { StatusCode.InternalServerError, new KeyValuePair<string, string>(TargetProcess.StatusCodes.StatusCodeTitles.InternalServerError, TargetProcess.StatusCodes.StatusCodeDetails.InternalServerError) },
            { StatusCode.NotImplemented, new KeyValuePair<string, string>(TargetProcess.StatusCodes.StatusCodeTitles.NotImplemented, TargetProcess.StatusCodes.StatusCodeDetails.NotImplemented) }
        };
    }
}
