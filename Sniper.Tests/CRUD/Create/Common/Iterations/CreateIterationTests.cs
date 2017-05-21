using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Iterations
{
    public class CreateIterationTests
    {
        [Fact]
        public void CreateIterationThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Iterations);

            var iteration = new Iteration();
        }
    }
}
