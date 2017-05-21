using Sniper.Application.Messages;
using Sniper.History;
using Xunit;
using static Sniper.TargetProcess.Routes.TargetProcessHistoryRoutes;

namespace Sniper.Tests.CRUD.Create.History.EpicSimpleHistories
{
    public class CreateEpicSimpleHistoryTests
    {
        [Fact]
        public void CreateEpicSimpleHistoryThrowsError()
        {
            var client = CommonMethods.GetClientByHistoryRoute(HistoryRoute.EpicSimpleHistories);
            var epicSimpleHistory = new EpicSimpleHistory();

            var data = client.CreateData<EpicSimpleHistory>(epicSimpleHistory);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }

}
