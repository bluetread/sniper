// ReSharper disable once CheckNamespace
namespace Sniper.Configuration
{
    public interface IRestfulData
    {
        string ApiUrl { get; } // Base url for all commands for the site
        string Password { get; set; } //Password, Token, etc. For anon, leave null/empty
        string UserName { get; set; } // UserName, Key, etc. For anon, leave null/empty

    }
}
