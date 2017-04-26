using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// Relation between user and following entity.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/GeneralFollowers/meta">API documentation - GeneralFollower</a>
    /// </remarks>
    public class GeneralFollower : IHasId, IHasGeneral, IHasUser
    {
        public int Id { get; set; }
        public General General { get; set; }
        public User User { get; set; }
    }
}
