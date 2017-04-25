namespace Sniper.Http
{
    public interface ICredentials
    {

        AuthenticationType AuthenticationType { get; } //anonymous (not allowed for TargetProcess), basic, cookie, accessToken, serviceToken or token (Service Token)
        string Login { get;  } // Login, UserName, Key, etc. For anon, leave null/empty
        string Password { get; set; } //Password, Token, etc. For anon, leave null/empty
        
    }
}