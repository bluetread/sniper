using Sniper.Application.Messages;
using Sniper.History;
using Xunit;
using static Sniper.TargetProcess.Routes.TargetProcessHistoryRoutes;

namespace Sniper.Tests.CRUD.Create.History.TaskSimpleHistories
{
    public class CreateTaskSimpleHistoryTests
    {
        [Fact]
        public void CreateTaskSimpleHistoryThrowsError()
        {
            var client = CommonMethods.GetClientByHistoryRoute(HistoryRoute.TaskSimpleHistories);
            var taskSimpleHistory = new TaskSimpleHistory();

            var data = client.CreateData<TaskSimpleHistory>(taskSimpleHistory);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }

}
