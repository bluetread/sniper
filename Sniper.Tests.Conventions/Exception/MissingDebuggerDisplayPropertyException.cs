using System;

namespace Sniper.Tests.Conventions.Exception
{
    public class MissingDebuggerDisplayPropertyException : System.Exception
    {
        public MissingDebuggerDisplayPropertyException(Type modelType)
            : base(string.Format("Model type '{0}' is missing the DebuggerDisplay property.", modelType.FullName))
        { }
    }
}