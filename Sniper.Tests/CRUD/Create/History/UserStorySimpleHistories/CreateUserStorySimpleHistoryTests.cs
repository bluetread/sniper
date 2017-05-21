using Sniper.Application.Messages;
using Sniper.History;
using Xunit;
using static Sniper.TargetProcess.Routes.TargetProcessHistoryRoutes;

namespace Sniper.Tests.CRUD.Create.History.UserStorySimpleHistories
{
    public class CreateUserStorySimpleHistoryTests
    {
        [Fact]
        public void CreateUserStorySimpleHistoryThrowsError()
        {
            var client = CommonMethods.GetClientByHistoryRoute(HistoryRoute.UserStorySimpleHistories);
            var userStorySimpleHistory = new UserStorySimpleHistory();

            var data = client.CreateData<UserStorySimpleHistory>(userStorySimpleHistory);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }

}
