namespace Sniper.Common
{
    ///<summary>
    /// Relation between two Entities.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Relations/meta">API documentation - Relation</a>
    /// </remarks>
    public class Relation : Entity
    {
        public General Master { get; set; }
        public RelationType RelationType { get; set; }
        public General Slave { get; set; }
    }
}