using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    ///
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Programs/meta">API documentation - Program</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Program : General, IHasProjects
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public Collection<Project> Projects { get; internal set; }
    }
}