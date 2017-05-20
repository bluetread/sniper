using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Companies
{
    public class CreateCompanyTests
    {
        [Fact]
        public void CreateCompanyThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Companies);

            var company = new Company();
        }
    }
}
