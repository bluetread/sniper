using Newtonsoft.Json;
using Sniper.Common;
using System.Collections.ObjectModel;
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
            int? userStoryId = result.Id;
            Assert.NotEqual(0, userStoryId);
        }


        [Fact]
        public void DeserializeObjectReturnedFromRead()
        {
            var data = StringExtensions.ConvertSingleQuotedJson(SingleQuotedJson.UserStoryFromReadResult);
            var result = JsonConvert.DeserializeObject<TargetProcessResponseWrapper<UserStory>>(
                data, JsonHelpers.DefaultSerializerSettings).Items;
            Assert.NotNull(result);
            Assert.IsType<Collection<UserStory>>(result);
        }
    }
}
