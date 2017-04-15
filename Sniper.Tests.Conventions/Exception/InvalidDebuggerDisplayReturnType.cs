using System;

namespace Sniper.Tests.Conventions.Exception
{
    public class InvalidDebuggerDisplayReturnType : System.Exception
    {
        public InvalidDebuggerDisplayReturnType(Type modelType, Type propertyType)
            : base(CreateMessage(modelType, propertyType))
        { }

        private static string CreateMessage(Type modelType, Type propertyType)
        {
            return string.Format(
                "Model type '{0}' has invalid DebuggerDisplay return type '{1}'. Expected 'string'.",
                modelType.FullName,
                propertyType.Name);
        }
    }
}