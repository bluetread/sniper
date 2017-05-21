using Sniper.Application.Messages;
using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Generals
{
    public class CreateGeneralTests
    {
        [Fact]
        public void CreateGeneralThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Generals);

            var general = new General();
            var data = client.CreateData<General>(general);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }
}
