using Newtonsoft.Json;
using Sniper.Common;
using Xunit;

using static Sniper.Tests.TestDataConstants;
namespace Sniper.Tests.Json
{
    public class JsonDeserializeTests
    {
        [Fact]
        public void DeserializeObjectReturnedFromCreate()
        {
            var data = StringExtensions.ConvertSingleQuotedJson(SingleQuotedJson.UserStoryFromCreateResult);
            var result = JsonConvert.DeserializeObject<UserStory>(data, JsonHelpers.DefaultSerializerSettings);
            Assert.NotNull(result);
            Assert.IsType<UserStory>(result);
            int userStoryId = result.Id;
            Assert.NotEqual(0, userStoryId);
        }
    }
}
