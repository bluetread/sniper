using Sniper.Application.Messages;
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
            var data = client.CreateData<User>(user);

            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.CreateProhibited);

        }

        [Fact]
        public void CreateExistingUserThrowsErrorForBadRequest()
        {
            var client = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Users) };

            // First, Create a user
            var user = new User { Email = "test@test.com", Login = "TestUser", Password = "test" };
            var data = client.CreateUser(user);
            Assert.False(data.HttpResponse.IsError);

            // Try to create user again, should fail.
            var data2 = client.CreateUser(user);
            Assert.True(data2.HttpResponse.IsError);
            Assert.IsType<TargetProcessBadRequestModel>(data2.HttpResponse.Data);

            //cleanup (Delete created user)
            var result = client.DeleteData<User>(data.Data.Id ?? 0);

            Assert.Equal(result.Data.Id, data.Data.Id);
            Assert.Null(result.Data.Email);
            Assert.Null(result.Data.Login);
            Assert.Null(result.Data.Password);
        }


        [Fact]
        public void CreateUserWithMinimumFieldsSucceeds()
        {
            var client = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Users) };
            // First, Create a user

            var user = new User { Email = "test@test.com", Login = "TestUser", Password = "test" };
            var data = client.CreateUser(user);
            var createdId = data.Data.Id ?? 0;
            Assert.NotEqual(0, createdId);
            Assert.NotNull(data);
            Assert.NotNull(data.Data);
            Assert.False(data.HttpResponse.IsError);

            //cleanup (Delete created user)
            client.DeleteData<User>(createdId);
        }
    }
}
