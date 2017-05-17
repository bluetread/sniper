using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Milestones
{
    public class ReadMilestoneTests
    { 
        [Fact] 
        public void MilestoneThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Milestones) 
            }; 
            var milestone = new Milestone 
            { 
            }; 
        } 
    } 
} 
