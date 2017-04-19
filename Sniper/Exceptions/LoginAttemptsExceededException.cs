using System;
using Sniper.Http;
using static Sniper.WarningsErrors.MessageSuppression;
using System.Diagnostics.CodeAnalysis;


namespace Sniper
{
    /// <summary>
    /// Represents a "Login Attempts Exceeded" response returned from the API.
    /// </summary>

    [Serializable]

    [SuppressMessage(Categories.Design, MessageAttributes.ImplementStandardExceptionConstructors, Justification = Justifications.SpecificToTargetProcess)]
    public class LoginAttemptsExceededException : ForbiddenException
    {
        /// <summary>
        /// Constructs an instance of LoginAttemptsExceededException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        public LoginAttemptsExceededException(IResponse response)
            : base(response)
        {
        }

        /// <summary>
        /// Constructs an instance of LoginAttemptsExceededException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="innerException">The inner exception</param>
        public LoginAttemptsExceededException(IResponse response, Exception innerException)
            : base(response, innerException)
        {
        }

        //public override string Message => ApiErrorMessageSafe ?? "Maximum number of login attempts exceeded";

   

    }
}
