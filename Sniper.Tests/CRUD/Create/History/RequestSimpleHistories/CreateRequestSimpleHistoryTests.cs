using Sniper.Application.Messages;
using Sniper.History;
using Xunit;
using static Sniper.TargetProcess.Routes.TargetProcessHistoryRoutes;

namespace Sniper.Tests.CRUD.Create.History.RequestSimpleHistories
{
    public class CreateRequestSimpleHistoryTests
    {
        [Fact]
        public void CreateRequestSimpleHistoryThrowsError()
        {
            var client = CommonMethods.GetClientByHistoryRoute(HistoryRoute.RequestSimpleHistories);
            var requestSimpleHistory = new RequestSimpleHistory();

            var data = client.CreateData<RequestSimpleHistory>(requestSimpleHistory);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }

}
