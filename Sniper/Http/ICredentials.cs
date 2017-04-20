namespace Sniper.Http
{
    public interface ICredentials
    {
        string Login { get; }
        string Password { get; }
        AuthenticationType AuthenticationType { get; }
    }
}