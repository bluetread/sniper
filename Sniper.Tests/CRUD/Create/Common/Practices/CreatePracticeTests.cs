using Sniper.Application.Messages;
using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Practices
{
    public class CreatePracticeTests
    {
        [Fact]
        public void CreatePracticeThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Practices);
            var practice = new Practice();
            var data = client.CreateData<General>(practice);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }
}
