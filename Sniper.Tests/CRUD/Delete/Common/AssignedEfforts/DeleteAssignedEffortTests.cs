using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.AssignedEfforts
{
    public class DeleteAssignedEffortTests 
     { 
        [Fact] 
        public void AssignedEffortThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.AssignedEfforts) 
            }; 
            var assignedEffort = new AssignedEffort 
            { 
            }; 
        } 
    } 
} 
