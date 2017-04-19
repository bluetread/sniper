using System;

namespace Sniper.Tests.Conventions.Exception
{
    public class MissingClientConstructorTestMethodException : System.Exception
    {
        public MissingClientConstructorTestMethodException(Type modelType)
            : base(CreateMessage(modelType))
        { }

        private static string CreateMessage(Type ctorTest)
        {
            return string.Format("Constructor test method is missing {0}.", ctorTest.FullName);
        }
    }
}