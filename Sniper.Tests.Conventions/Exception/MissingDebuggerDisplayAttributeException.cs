using System;

namespace Sniper.Tests.Conventions.Exception
{
    public class MissingDebuggerDisplayAttributeException : System.Exception
    {
        public MissingDebuggerDisplayAttributeException(Type modelType)
            : base(string.Format("Model type '{0}' is missing the DebuggerDisplayAttribute.", modelType.FullName))
        { }
    }
}