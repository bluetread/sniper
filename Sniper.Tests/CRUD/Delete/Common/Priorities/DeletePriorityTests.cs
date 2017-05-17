using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Priorities
{
    public class DeletePriorityTests 
     { 
        [Fact] 
        public void PriorityThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Priorities) 
            }; 
            var priority = new Priority 
            { 
            }; 
        } 
    } 
} 
