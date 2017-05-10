using Sniper.Contracts.Exceptions;
using System;

namespace Sniper
{
    public static class SniperExceptions
    {
        public class RequiredPropertyException : ApplicationException
        {
            public IRequiredDataResponse RequiredDataResponse { get; set; }

            public RequiredPropertyException() {}
            public RequiredPropertyException(string propertyName) : base(propertyName) { }

            public RequiredPropertyException(IRequiredDataResponse requiredDataResponse)
            {
                RequiredDataResponse = requiredDataResponse;
            }
        }
    }
}
