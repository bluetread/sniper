using System;

namespace Sniper.Tests.Conventions.Exception
{
    public class MissingClientConstructorTestClassException : System.Exception
    {
        public MissingClientConstructorTestClassException(Type modelType)
            : base(CreateMessage(modelType))
        { }

        private static string CreateMessage(Type ctorTest)
        {
            return string.Format("Constructor test class is missing {0}.", ctorTest.FullName);
        }
    }
}