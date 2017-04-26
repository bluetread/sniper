namespace Sniper.Authentication
{
    public class User : IUser
    {
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
