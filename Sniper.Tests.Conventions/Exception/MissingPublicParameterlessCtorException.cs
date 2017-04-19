using System;

namespace Sniper.Tests.Conventions.Exception
{
    public class MissingPublicParameterlessCtorException : System.Exception
    {
        public MissingPublicParameterlessCtorException(Type modelType)
            : base(string.Format("Model type '{0}' is missing a Public Parameterless Constructor required by SimpleJson Deserializer.", modelType.FullName))
        { }
    }
}