namespace Sniper
{
    /// <summary>
    /// Authentication protocols supported by the GitHub API
    /// </summary>
    public enum AuthenticationType
    {
        /// <summary>
        /// Cookie Authentication
        /// </summary>
        Cookie,
        /// <summary>
        /// User name &amp; password
        /// </summary>
        Basic,
        /// <summary>
        /// Delegated access to a third party
        /// </summary>
        Oauth
    }
}
