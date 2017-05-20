using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Users
{
    public class CreateUserTests
    {
        [Fact]
        public void CreateUserThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Users);
            var user = new User();
        }
        [Fact]
        public void CreateExistingUserThrowsErrorForBadRequest()
        {
            var client = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Users) };
            // First, Create a user

            var user = new User { Email = "test@test.com", Password = "test", Login = "TestUser" };
            var data = client.CreateUser(user);
            Assert.False(data.HttpResponse.IsError);

            var data2 = client.CreateUser(user);
            Assert.True(data2.HttpResponse.IsError);
            Assert.IsType<TargetProcessBadRequestModel>(data2.Data);


        }
        [Fact]
        public void CreateUserWithMinimumFieldsSucceeds()
        {
            var client = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Users) };
            // First, Create a user

            var user = new User { Email = "test@test.com", Password = "test", Login = "TestUser" };
            var data = client.CreateUser(user);
            var createdId = data.Data.Id;
            Assert.NotEqual(0, createdId);
            Assert.NotNull(data);
            Assert.NotNull(data.Data);
            Assert.False(data.HttpResponse.IsError);
        }
    }
}
