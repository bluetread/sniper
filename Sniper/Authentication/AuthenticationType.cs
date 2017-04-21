namespace Sniper
{
    /// <summary>
    /// Authentication protocols supported by the TargetProcess API
    /// </summary>
    public enum AuthenticationType
    {
        /// <summary>
        /// Access Token
        /// </summary>
        AccessToken,
        /// <summary>
        /// Anonymous Authentication (Not Allowed)
        /// </summary>
        Anonymous,
        /// <summary>
        /// Cookie Authentication
        /// </summary>
        Cookie,
        /// <summary>
        /// User name &amp; password
        /// </summary>
        Basic,
        /// <summary>
        /// Service Token
        /// </summary>
        ServiceToken
    }
}
