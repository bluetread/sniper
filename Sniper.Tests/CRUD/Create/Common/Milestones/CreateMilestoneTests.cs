using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Milestones
{
    public class CreateMilestoneTests
    {
        [Fact]
        public void MilestoneThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Milestones);

            var milestone = new Milestone();
        }
    }
}
