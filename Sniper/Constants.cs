namespace Sniper
{
    public static class Constants
    {
        public static class Application
        {
            public static class Messages
            {
                public const string StandardKeyValueFormat = @"{0}:{1}";
                public const string EmptyPassword = "Passwords should never be null/empty";
            }
        }

        public static class Authentication
        {
            public const string CredentialStore = "credentialStore";
            public const string Credentials = "credentials";
            public const string CredentialsLogin = "credentials.Login";
            public const string CredentialsPassword = "credentials.Password";
            public const string Request = "request";

            public static class Keys
            {
                public const string Authorization = "Authorization";
            }

            public static class Messages
            {
                public const string BasicAuthorizationMessageFormat = @"Basic {0}";
                public const string TokenAuthorizationMessageFormat = @"Basic {0}";
                public const string EmptyPassword = "Passwords should never be null/empty";
                public const string TokenLoginFailed = 
                    "The Login is not null for a token authentication request. You probably did something wrong.";
            }
        }

        public static class ApiClient
        {
            public const string Connection = "apiConnection";
        }

     

    }
}
