using Sniper.Application.Messages;
using Sniper.History;
using Xunit;
using static Sniper.TargetProcess.Routes.TargetProcessHistoryRoutes;

namespace Sniper.Tests.CRUD.Create.History.FeatureSimpleHistories
{
    public class CreateFeatureSimpleHistoryTests
    {
        [Fact]
        public void CreateFeatureSimpleHistoryThrowsError()
        {
            var client = CommonMethods.GetClientByHistoryRoute(HistoryRoute.FeatureSimpleHistories);
            var featureSimpleHistory = new FeatureSimpleHistory();

            var data = client.CreateData<FeatureSimpleHistory>(featureSimpleHistory);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }

}
