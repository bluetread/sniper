using Sniper.Application.Messages;
using Sniper.History;
using Xunit;
using static Sniper.TargetProcess.Routes.TargetProcessHistoryRoutes;

namespace Sniper.Tests.CRUD.Create.History.ImpedimentSimpleHistories
{
    public class CreateImpedimentSimpleHistoryTests
    {
        [Fact]
        public void CreateImpedimentSimpleHistoryThrowsError()
        {
            var client = CommonMethods.GetClientByHistoryRoute(HistoryRoute.ImpedimentSimpleHistories);
            var impedimentSimpleHistory = new ImpedimentSimpleHistory();

            var data = client.CreateData<ImpedimentSimpleHistory>(impedimentSimpleHistory);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }

}
