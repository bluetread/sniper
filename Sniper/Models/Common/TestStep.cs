using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Single Step of Test Case
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestSteps/meta">API documentation - TestStep</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class TestStep : Entity, IHasDescription, IHasTestCase
    {
        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Result { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int RunOrder { get; set; }

        [JsonProperty(Required = Required.Default)]
        public TestCase TestCase { get; set; }
    }
}