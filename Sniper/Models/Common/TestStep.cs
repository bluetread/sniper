using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// Single Step of Test Case
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestSteps/meta">API documentation - TestStep</a>
    /// </remarks>
    public class TestStep : IHasId, IHasDescription, IHasTestCase
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        public int RunOrder { get; set; }

        public TestCase TestCase { get; set; }
    }
}