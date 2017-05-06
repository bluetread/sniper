using Sniper.Contracts.Entities.Common;

namespace Sniper.Common
{
    ///<summary>
    /// Single Step of Test Case
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestSteps/meta">API documentation - TestStep</a>
    /// </remarks>
    public class TestStep : Entity, IHasDescription, IHasTestCase
    {
        public string Description { get; set; }
        public string Result { get; set; }
        public int RunOrder { get; set; }

        public TestCase TestCase { get; set; }
    }
}