using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Priorities
{
    public class CreatePriorityTests
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
