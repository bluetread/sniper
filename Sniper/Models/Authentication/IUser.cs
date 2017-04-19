namespace Sniper.Authentication
{
    public interface IUser
    {
        string Password { get; set; }
        string UserName { get; set; }
    }
}
